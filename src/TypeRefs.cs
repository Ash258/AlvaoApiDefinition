using System.Text.RegularExpressions;
using HtmlAgilityPack;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

// Reference to a top-level type. Nested types (Kind.DataType) are represented by their top-level parent (Kind),
// as that is the only part which has to be resolved by usings or qualified.
public record TypeRef(string Namespace, string Name) {
    public string FullName => $"{Namespace}.{Name}";
}

// Resolves type references from docfx pages.
// Definitions on the page are plain text, but every type used in them is also rendered as xref link (or span when
// the type is not documented) in parameters/returns/inheritance blocks. Links contain the full type name, which is
// used to generate usings and to fully qualify types, which would be ambiguous or resolved to different type.
public static partial class TypeRefs {
    private const string MS_API = "learn.microsoft.com/dotnet/api/";

    // Namespaces imported by <ImplicitUsings>enable</ImplicitUsings>
    public static readonly HashSet<string> ImplicitUsings = [
        "System",
        "System.IO",
        "System.Collections.Generic",
        "System.Linq",
        "System.Net.Http",
        "System.Threading",
        "System.Threading.Tasks",
    ];

    private static readonly HashSet<string> Keywords = [
        "bool", "byte", "sbyte", "char", "decimal", "double", "float", "int", "uint", "long", "ulong",
        "short", "ushort", "object", "string", "void", "dynamic", "nint", "nuint",
    ];

    // learn.microsoft.com urls are lowercase. Segments, which are not simply capitalized
    private static readonly Dictionary<string, string> SegmentCasing = new() {
        ["io"] = "IO",
        ["sqlclient"] = "SqlClient",
        ["xpath"] = "XPath",
        ["ai"] = "AI",
    };

    private const string TYPE_BLOCKS = "descendant-or-self::dl[contains(@class, 'parameters') or contains(@class, 'inheritance') or contains(@class, 'implements')]";

    /// Collect type references from elements of one member (or class header).
    /// <param name="uid">data-uid of the member heading. It contains fully qualified parameter types, which is used for types without link.</param>
    public static List<TypeRef> Collect(IEnumerable<HtmlNode> elements, string uid, string ownName, string ownNamespace) {
        List<TypeRef> refs = [];
        var ownTopName = TopLevelName(ownName);

        foreach (var dl in elements.SelectMany(el => (IEnumerable<HtmlNode>?)el.SelectNodes(TYPE_BLOCKS) ?? [])) {
            foreach (var a in (IEnumerable<HtmlNode>?)dl.SelectNodes(".//a[contains(@class, 'xref')]") ?? []) {
                var r = FromLink(a.GetAttributeValue("href", ""), SanitizeXmlToString(TrimInnerText(a)));
                if (r == null) continue;

                refs.Add(r);
                // Linked page, which is not listed in its namespace (documentation pages from different versions)
                if (r.Namespace.StartsWith("Alvao") && !r.Name.Equals(ownTopName) && !State.IsDocumentedType(r.Namespace, r.Name)) {
                    State.Stubs.TryAdd(r.FullName, r);
                }
            }

            foreach (var span in (IEnumerable<HtmlNode>?)dl.SelectNodes(".//span[contains(@class, 'xref')]") ?? []) {
                var r = FromUnlinked(span, uid, ownTopName, ownNamespace);
                if (r == null) continue;

                refs.Add(r);
                // Undocumented Alvao type => generate empty stub, so the project is compilable
                if (r.Namespace.StartsWith("Alvao") && !State.IsDocumentedType(r.Namespace, r.Name)) {
                    State.Stubs.TryAdd(r.FullName, r);
                }
            }
        }

        refs = [.. refs.Distinct()];
        refs.ForEach(r => State.RegisterType(r.Namespace, r.Name));

        return refs;
    }

    internal static TypeRef? FromLink(string href, string text) {
        href = href.Split('#')[0].Split('?')[0];

        if (href.Contains(MS_API)) {
            if (Keywords.Contains(text)) return null;

            var path = href[(href.IndexOf(MS_API) + MS_API.Length)..];
            // Tuples are linked as system.valuetuple-system.single[],system.boolean-
            if (!SimpleMsPathRegex().IsMatch(path)) return null;

            var parts = path
                .Split('.')
                .Select(p => ArityRegex().Replace(p, ""))
                .ToArray();
            // Links to members (system.exception.message) or nested types cannot be mapped to namespace reliably
            if (parts.Length < 2 || !parts[^1].Equals(text, StringComparison.OrdinalIgnoreCase)) return null;

            // Patches can redirect external types (e.g. packages, which are not referenced by the library)
            if (Patches.Instance.TypeNamespaces.TryGetValue(text, out var redirected)) return new TypeRef(redirected, text);

            return new TypeRef(string.Join('.', parts[..^1].Select(CaseSegment)), text);
        }

        if (href.Contains("://") || !href.EndsWith(".html")) return null;

        // Alvao page: Namespace.Type[.Nested].html, generic types have arity suffix (CollectionResponse-1)
        var name = string.Join('.', href[..^".html".Length].Split('.').Select(p => ArityRegex().Replace(p, "")));
        var ns = State.AllNamespaces
            .Where(n => name.StartsWith($"{n}."))
            .MaxBy(n => n.Length);
        if (ns == null) return null;

        return new TypeRef(ns, name[(ns.Length + 1)..].Split('.')[0]);
    }

    private static TypeRef? FromUnlinked(HtmlNode span, string uid, string ownTopName, string ownNamespace) {
        var top = TopLevelName(SanitizeXmlToString(TrimInnerText(span)));

        // Generic parameters (T), keywords and self references (inheritance list always contains self)
        if (top.Length <= 1 || Keywords.Contains(top) || top.Equals(ownTopName)) return null;

        // Nested type of other type (ModuleInfo.ModuleId is rendered as 2 spans), parent is resolved instead
        if (span.PreviousSibling is HtmlTextNode prev && prev.Text.TrimEnd().EndsWith('.')) return null;

        // Explicit patch wins
        if (Patches.Instance.TypeNamespaces.TryGetValue(top, out var ns)) return new TypeRef(ns, top);

        // data-uid contains fully qualified parameter types: Email.Queue(Rebex.Mail.MailMessage,...)
        var m = Regex.Match(uid, $@"(?<![\w.])((?:\w+\.)+){Regex.Escape(top)}(?![\w])");
        if (m.Success) return new TypeRef(m.Groups[1].Value.TrimEnd('.'), top);

        // Unknown, expect it lives next to the class, which references it
        return new TypeRef(ownNamespace, top);
    }

    /// Namespace, which C# would bind short type name to. null when ambiguous or unknown.
    public static string? Resolve(string name, string ownNamespace, ISet<string> usings) {
        if (!State.KnownTypes.TryGetValue(name, out var namespaces)) return null;

        // Types (and nested namespaces) in current and enclosing namespaces win over usings
        for (var ns = ownNamespace; !string.IsNullOrEmpty(ns); ns = ParentNamespace(ns)) {
            if (namespaces.Contains(ns)) return ns;
            // Alvao.API.Common.Model.Database namespace shadows Alvao.API.Common.Database class inside Alvao.API.Common.Model
            if (State.AllNamespaces.Contains($"{ns}.{name}")) return null;
        }

        var candidates = namespaces.Where(n => usings.Contains(n) || ImplicitUsings.Contains(n)).ToList();

        return candidates.Count == 1 ? candidates[0] : null;
    }

    /// Fully qualify every referenced type, which would not be bound to the referenced type by short name.
    /// <param name="selfNames">Own class name and names of its nested types (they shadow everything else)</param>
    public static string Qualify(string definition, IEnumerable<TypeRef> refs, string ownNamespace, string ownTopName, ISet<string> selfNames, ISet<string> usings) {
        foreach (var r in refs) {
            if (r.Name.Equals(ownTopName) && r.Namespace.Equals(ownNamespace)) continue;

            var resolved = selfNames.Contains(r.Name) ? null : Resolve(r.Name, ownNamespace, usings);
            if (r.Namespace.Equals(resolved)) continue;

            // Only type positions: followed by identifier, generic/array/nullable/tuple punctuation or end.
            // Member names (followed by '(' or '{') stay untouched.
            definition = Regex.Replace(
                definition,
                $@"(?<![\w.@]){Regex.Escape(r.Name)}(?=\s+[A-Za-z_@]|\s*[<>,\[\]?.)]|\s*$)",
                r.FullName
            );
        }

        return definition;
    }

    public static IEnumerable<string> UsingsFor(IEnumerable<TypeRef> refs, string ownNamespace) {
        return refs
            .Select(r => r.Namespace)
            .Distinct()
            .Where(ns => !ImplicitUsings.Contains(ns) && !IsSameOrEnclosingNamespace(ns, ownNamespace));
    }

    public static string TopLevelName(string name) => name.Split('.')[0].Split('<')[0].Trim();

    private static bool IsSameOrEnclosingNamespace(string ns, string ownNamespace) =>
        ownNamespace.Equals(ns) || ownNamespace.StartsWith($"{ns}.");

    private static string ParentNamespace(string ns) => ns.Contains('.') ? ns[..ns.LastIndexOf('.')] : string.Empty;

    private static string CaseSegment(string segment) =>
        SegmentCasing.TryGetValue(segment, out var cased) ? cased : char.ToUpperInvariant(segment[0]) + segment[1..];

    [GeneratedRegex(@"-\d+$")]
    private static partial Regex ArityRegex();

    [GeneratedRegex(@"^[a-z0-9]+(?:\.[a-z0-9]+(?:-\d+)?)*$")]
    private static partial Regex SimpleMsPathRegex();
}
