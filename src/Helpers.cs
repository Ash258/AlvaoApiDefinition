using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;

namespace AlvaoScrapper;

public static class Helpers {
    public static string ALVAO_VERSION = "25";
    public static string ALVAO_VERSION_DOT = ALVAO_VERSION.Replace("_", ".");
    public static string BASE_URL = $"https://doc.alvao.com/en/{ALVAO_VERSION}/alvao-api";
    public static string BASE_HTML_URL = $"{BASE_URL}/api";
    public static string LOCAL_HTML_FOLDER = "html";
    public static bool IGNORE_CACHE = false;

    public enum MemberDefinitionType {
        PropertyOrFieldOrEvent,
        Constructor,
        Method,
        Enum,
    }

    public static ILogger<T> CreateLogger<T>(string filterName = "AlvaoScrapper", string envName = "Logging__LogLevel__AlvaoScrapper", string defaultValue = "4") {
        var loggerFactory = LoggerFactory.Create(builder => {
            builder.AddFilter(filterName, (LogLevel)int.Parse(Environment.GetEnvironmentVariable(envName) ?? defaultValue));
            builder.AddSimpleConsole(options => {
                options.IncludeScopes = true;
                options.SingleLine = true;
            });
        });

        return loggerFactory.CreateLogger<T>();
    }

    public static HtmlDocument LoadDocument(string url, string localPath) {
        var doc = new HtmlDocument();
        if (!IGNORE_CACHE && File.Exists(localPath)) {
            doc.Load(localPath);
        } else {
            doc = new HtmlWeb().Load(url);
            File.WriteAllText(localPath, doc.Text);
        }

        return doc;
    }

    public static void AssertDirectory(string folder) {
        if (Directory.Exists(folder)) return;

        Directory.CreateDirectory(folder);
    }

    public static string TrimInnerText(HtmlNode node) {
        return node.InnerText.Trim();
    }

    public static string ReplaceEndLinesWithSpace(string el) {
        return Regex.Replace(el, @"\r?\n\s*", " ");
    }

    public static string GetSummary(HtmlDocument _document) {
        var _node = _document.DocumentNode.SelectSingleNode("//article/div[@class='markdown summary']");
        if (_node == null) return "";

        var _s = TrimInnerText(_node);
        if (_s == null) return "";

        return ReplaceEndLinesWithSpace(_s);
    }

    // Replace enncoded xml tags with normal characters
    public static string SanitizeXmlToString(string el) {
        return el
            .Replace("&amp;", "&")
            .Replace("&nbsp;", " ")
            .Replace("&lt;", "<")
            .Replace("&gt;", ">")
            .Replace("&#39;", "'")
            .Replace("&quot;", "\"")
            .Trim();
    }

    internal static string PrefixEachLineSpacesDoc(string el, int indent = 4) {
        return PrefixEachLineSpaces(el, indent, true);
    }

    internal static string PrefixEachLineSpaces(string el, int indent = 4, bool includeDocComment = false) {
        var ind = new string(' ', indent);
        var comment = includeDocComment ? "/// " : "";
        var prefix = $"{ind}{comment}";

        return el.Contains('\n')
            ? TrimEndNewLine(el.Split('\n').Select(x => $"{prefix}{TrimEndNewLine(x)}").ToArray().JoinAsString("\n"))
            : TrimEndNewLine($"{prefix}{el}");
    }

    public static string TrimEndNewLine(string el) {
        return el.TrimEnd().TrimEnd('\n').TrimEnd('\r').TrimEnd('\n').TrimEnd('\r');
    }

    internal static bool IsClass(AlvaoClass clazz, string namespaceName, string className) {
        return clazz.NamespaceName.Equals(namespaceName) && clazz.Name.Equals(className);
    }

    public static void AddUsingByClassName(string expectedName, string namespaceName, string className, List<string> toAdd) {
        if (!className.Equals(expectedName)) return;

        toAdd.Add(namespaceName);
    }

    // Generate doc comment summary
    public static void GenerateSummary(string summary, int indent, List<(string, string)> examples, StringBuilder sb, bool useValueElement = false) {
        // Do nothing when summary and Examples are empty
        if (string.IsNullOrEmpty(summary) && examples.Count == 0) return;

        var element = useValueElement ? "value" : "summary";
        var sum = summary.Trim();

        //Add single line summary
        if (examples.Count == 0 && !summary.Contains('\n')) {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<{element}>{sum}</{element}>", indent));
            return;
        }

        sb.AppendLine(PrefixEachLineSpacesDoc($"<{element}>", indent));
        if (!string.IsNullOrEmpty(summary)) {
            sb.AppendLine(PrefixEachLineSpacesDoc(sum, indent));
        }

        examples.ForEach(x => {
            sb.AppendLine(PrefixEachLineSpacesDoc("<example>", indent));
            sb.AppendLine(PrefixEachLineSpacesDoc("<code>", indent));
            sb.AppendLine(PrefixEachLineSpacesDoc(x.Item2, indent));
            sb.AppendLine(PrefixEachLineSpacesDoc("</code>", indent));
            sb.AppendLine(PrefixEachLineSpacesDoc("</example>", indent));
        });
        sb.AppendLine(PrefixEachLineSpacesDoc($"</{element}>", indent));
    }

    // Generate doc comment see with URL
    public static void GenerateSeeUrl(string? fullUrl, int indent, StringBuilder sb) {
        if (string.IsNullOrEmpty(fullUrl)) return;

        sb.AppendLine(PrefixEachLineSpacesDoc($"<see href=\"{fullUrl}\"/>", indent));
    }

    // Generate param docs only when there is description
    public static void GenerateParameters(List<(string, string)> parameters, int indent, StringBuilder sb) {
        parameters.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(param => {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<param name=\"{param.Item1}\">{param.Item2}</param>", indent));
        });
    }

    // Generate member definition
    public static void GenerateDefinition(string definition, MemberDefinitionType type, int indent, StringBuilder sb, List<string> fields = null) {
        sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(definition), indent));

        var append = string.Empty;

        switch (type) {
            case MemberDefinitionType.Enum:
                sb.Append(" {");

                if (fields != null && fields.Count > 0) {
                    fields.Sort((a, b) => {
                        var aNum = int.Parse(a.Split('=')[1].Trim().TrimEnd(',').Trim());
                        var bNum = int.Parse(b.Split('=')[1].Trim().TrimEnd(',').Trim());

                        return aNum.CompareTo(bNum);
                    });

                    fields.ForEach(f => {
                        sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(f), indent * 2));
                        sb.AppendLine(",");
                    });
                }

                sb.Append(PrefixEachLineSpaces("}", indent));
                break;
            case MemberDefinitionType.PropertyOrFieldOrEvent:
                if (!definition.EndsWith('}')) append = ";";
                break;
            case MemberDefinitionType.Method:
                if (!definition.EndsWith(';')) append = " { throw new System.NotImplementedException(); }";
                break;
            case MemberDefinitionType.Constructor:
                append = " {}";
                break;
            default:
                append = " {}";
                break;
        }

        if (string.IsNullOrEmpty(append)) return;

        sb.Append(append);
    }

    // Generates doc comment returns
    public static void GenerateSingleOrMultiLineElement(string val, int indent, string elementName, StringBuilder sb) {
        if (string.IsNullOrEmpty(val)) return;

        if (val.Contains('\n')) {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<{elementName}>", indent));
            sb.AppendLine(PrefixEachLineSpacesDoc(val, indent));
            sb.AppendLine(PrefixEachLineSpacesDoc($"</{elementName}>", indent));
        } else {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<{elementName}>{val}</{elementName}>", indent));
        }
    }
}
