using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DbColumn(string Name, string Type, string Description, string? References) {
    public bool IsNullable => Type.EndsWith(", null");
    // nvarchar(1024), null => nvarchar
    public string SqlType => Regex.Match(Type, @"^\w+").Value;
}

public record DbTable(string Schema, string Name, string Description, List<DbColumn> Columns) {
    public string FullName => $"{Schema}.{Name}";
}

// ALVAO database tables from https://doc.alvao.com/en/{version}/admin-guide/customization/alvao-database/tables/
// Used to enrich generated database models, to generate models of undocumented tables and DATABASE.md.
public static partial class DatabaseSchema {
    public const string MODELS_NAMESPACE = "Alvao.API.Common.Model.Database";
    private const string CAUTION = "!!!CAUTION: This class is not part of the API documentation. It was generated from the database documentation";

    private static string Url => $"https://doc.alvao.com/en/{ALVAO_VERSION}/admin-guide/customization/alvao-database/tables/";

    private static Dictionary<string, DbTable>? _tables;

    // Table name => table (names are unique across schemas)
    public static Dictionary<string, DbTable> Tables => _tables ??= Load();

    private static Dictionary<string, DbTable> Load() {
        // The page uses unclosed tags (<td><p>...), which html parsers nest differently, so the raw source is parsed.
        // Works for both the original and tidied page.
        var source = LoadDocument(Url, Path.Combine(LOCAL_HTML_FOLDER, "database-tables.html")).Text;
        Dictionary<string, DbTable> tables = [];

        // <h2 id="U_dbo.tHdTicket">, followed by <p> description and <table> of columns
        var headings = HeadingRegex().Matches(source);
        for (var i = 0; i < headings.Count; i++) {
            var start = headings[i].Index + headings[i].Length;
            var end = i + 1 < headings.Count ? headings[i + 1].Index : source.Length;
            var body = source[start..end];

            var fullName = headings[i].Groups[1].Value;
            var schema = fullName.Split('.')[0];
            var name = fullName[(schema.Length + 1)..];

            var tableStart = body.IndexOf("<table", StringComparison.Ordinal);
            var intro = tableStart < 0 ? body : body[..tableStart];
            var description = ParagraphRegex().Match(intro) is { Success: true } p ? Text(p.Groups[1].Value) : string.Empty;

            List<DbColumn> columns = [];
            if (tableStart >= 0) {
                var table = body[tableStart..];
                var tbody = table.IndexOf("<tbody", StringComparison.Ordinal);
                var tableEnd = table.IndexOf("</table>", StringComparison.Ordinal);
                if (tbody >= 0 && tableEnd > tbody) {
                    foreach (var row in RowRegex().Split(table[tbody..tableEnd]).Skip(1)) {
                        var cells = CellRegex().Split(row).Skip(1).ToArray();
                        if (cells.Length < 2) continue;

                        var reference = ReferenceRegex().Match(cells[0]);
                        columns.Add(new DbColumn(
                            Text(cells[0]),
                            Text(cells[1]),
                            cells.Length > 2 ? Text(cells[2]) : string.Empty,
                            reference.Success ? reference.Groups[1].Value : null
                        ));
                    }
                }
            }

            tables.TryAdd(name, new DbTable(schema, name, description, columns));
        }

        return tables;
    }

    // Strip tags and collapse whitespace. Html entities stay encoded, so the text can be used in doc comments directly
    private static string Text(string fragment) => WhitespaceRegex().Replace(TagRegex().Replace(fragment, ""), " ").Trim();

    // Add column information to properties of database model and fill in missing descriptions
    public static void Enrich(AlvaoClass clazz) {
        if (!clazz.NamespaceName.Equals(MODELS_NAMESPACE)) return;

        var tableName = TableAttributeRegex().Match(clazz.Definition) is { Success: true } m ? m.Groups[1].Value : clazz.Name;
        if (!Tables.TryGetValue(tableName.Split('.')[^1], out var table)) return;

        if (string.IsNullOrEmpty(clazz.Summary)) clazz.Summary = table.Description;

        foreach (var property in clazz.Properties.Concat(clazz.Fields)) {
            var column = table.Columns.FirstOrDefault(c => c.Name.Equals(property.Name));
            if (column == null) continue;

            if (string.IsNullOrEmpty(property.Summary)) property.Summary = column.Description;
            property.Remarks = ColumnRemarks(column);
        }
    }

    private static string ColumnRemarks(DbColumn column) {
        var remarks = $"Column <c>{column.Name}</c>: {column.Type}.";
        if (column.References == null) return remarks;

        var target = column.References.Split('.')[^1];
        var link = State.IsDocumentedType(MODELS_NAMESPACE, target) || Tables.ContainsKey(target)
            ? $"<see cref=\"{target}\"/>"
            : $"<c>{column.References}</c>";

        return $"{remarks} References {link}.";
    }

    // Models for documented tables, which are not part of the API documentation
    public static void GenerateMissingModels(ILogger logger) {
        var folder = MODELS_NAMESPACE.Replace(".", "/");
        AssertDirectory(folder);

        foreach (var table in Tables.Values.Where(t => !State.IsKnownType(MODELS_NAMESPACE, t.Name)).OrderBy(t => t.Name)) {
            logger.LogInformation("Generating model for undocumented table {}", table.FullName);
            State.RegisterType(MODELS_NAMESPACE, table.Name);

            var sb = new StringBuilder();
            sb.AppendLine("using Dapper.Contrib.Extensions;");
            sb.AppendLine();
            sb.AppendLine($"namespace {MODELS_NAMESPACE};");
            sb.AppendLine();
            GenerateSummary(string.IsNullOrEmpty(table.Description) ? CAUTION : $"{table.Description}<br/><br/>{CAUTION}", 0, [], sb);
            GenerateSeeUrl($"{Url}#U_{table.FullName}", 0, sb);
            sb.AppendLine($"[Table(\"{table.FullName}\")]");
            sb.AppendLine($"public class {table.Name} {{");
            foreach (var column in table.Columns) {
                // Member cannot have the same name as its class (column AppOperation in table AppOperation)
                var propertyName = column.Name.Equals(table.Name) ? $"{column.Name}Value" : column.Name;
                var property = new DotnetPropertyOrFieldOrEvent() {
                    Name = propertyName,
                    Summary = column.Description,
                    Remarks = ColumnRemarks(column),
                    Definition = $"public virtual {ClrType(column)} {propertyName} {{ get; set; }}",
                };
                sb.AppendLine(property.Produce());
            }
            sb.AppendLine("}");

            File.WriteAllText($"{folder}/{table.Name}.cs", sb.ToString());
        }
    }

    private static string ClrType(DbColumn column) {
        var (type, isValueType) = column.SqlType switch {
            "bigint" => ("long", true),
            "int" => ("int", true),
            "smallint" => ("short", true),
            "tinyint" => ("byte", true),
            "bit" => ("bool", true),
            "float" => ("double", true),
            "real" => ("float", true),
            "decimal" or "numeric" or "money" or "smallmoney" => ("decimal", true),
            "date" or "datetime" or "datetime2" or "smalldatetime" => ("DateTime", true),
            "datetimeoffset" => ("DateTimeOffset", true),
            "time" => ("TimeSpan", true),
            "uniqueidentifier" => ("Guid", true),
            "varbinary" or "binary" or "image" or "timestamp" or "rowversion" => ("byte[]", false),
            "vector" => ("float[]", false),
            "nvarchar" or "varchar" or "nchar" or "char" or "ntext" or "text" or "xml" => ("string", false),
            _ => ("object", false),
        };

        return isValueType && column.IsNullable ? $"{type}?" : type;
    }

    // Readable schema reference for people and AI assistants writing SQL
    public static void WriteMarkdown(string path, string version) {
        var sb = new StringBuilder();
        sb.AppendLine("# ALVAO database tables");
        sb.AppendLine();
        sb.AppendLine($"ALVAO {version} database schema, generated from the [ALVAO documentation]({Url}).");
        sb.AppendLine("Tables with a model in `Alvao.API.Common.Model.Database` can be loaded with Dapper (`[Table]` attribute).");
        sb.AppendLine();
        sb.AppendLine("> [!CAUTION]");
        sb.AppendLine("> Unofficial, not affiliated with ALVAO s.r.o. Correctness is not guaranteed.");
        sb.AppendLine();

        foreach (var schema in Tables.Values.GroupBy(t => t.Schema).OrderBy(g => g.Key)) {
            foreach (var table in schema.OrderBy(t => t.Name, StringComparer.OrdinalIgnoreCase)) {
                sb.AppendLine($"## {table.FullName}");
                sb.AppendLine();
                if (!string.IsNullOrEmpty(table.Description)) {
                    sb.AppendLine(Markdown(table.Description));
                    sb.AppendLine();
                }
                if (table.Columns.Count == 0) continue;

                sb.AppendLine("| Column | Type | References | Description |");
                sb.AppendLine("| :--- | :--- | :--- | :--- |");
                foreach (var c in table.Columns) {
                    sb.AppendLine($"| `{c.Name}` | {c.Type} | {(c.References == null ? "" : $"`{c.References}`")} | {Markdown(c.Description)} |");
                }
                sb.AppendLine();
            }
        }

        File.WriteAllText(path, sb.ToString());
    }

    private static string Markdown(string text) => SanitizeXmlToString(text).Replace("|", "\\|");

    [GeneratedRegex(@"<h2[^>]*\bid=\s*""?U_([\w.]+)""?[^>]*>.*?</h2>", RegexOptions.Singleline)]
    private static partial Regex HeadingRegex();

    [GeneratedRegex(@"<p[^>]*>(.*?)</p>", RegexOptions.Singleline)]
    private static partial Regex ParagraphRegex();

    [GeneratedRegex(@"<tr[^>]*>")]
    private static partial Regex RowRegex();

    [GeneratedRegex(@"<td[^>]*>")]
    private static partial Regex CellRegex();

    [GeneratedRegex(@"href=\s*""?#U_([\w.]+)")]
    private static partial Regex ReferenceRegex();

    [GeneratedRegex(@"<[^>]+>")]
    private static partial Regex TagRegex();

    [GeneratedRegex(@"\s+")]
    private static partial Regex WhitespaceRegex();

    [GeneratedRegex(@"\[Table\(""([^""]+)""\)\]")]
    private static partial Regex TableAttributeRegex();
}
