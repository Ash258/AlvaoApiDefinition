using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;

namespace AlvaoScrapper;

public static class Helpers {
    // Major version of the documentation. ALVAO_VERSION env variable wins, then .alvaorc (written by the generator)
    public static string ALVAO_VERSION = (Environment.GetEnvironmentVariable("ALVAO_VERSION")
        ?? (File.Exists(".alvaorc") ? File.ReadAllText(".alvaorc").Trim() : null)
        ?? "26").Split(".")[0];
    public static string ALVAO_VERSION_DOT = ALVAO_VERSION.Replace("_", ".");
    public static string BASE_URL = $"https://doc.alvao.com/en/{ALVAO_VERSION}/alvao-api";
    public static string BASE_HTML_URL = $"{BASE_URL}/api";
    public static string LOCAL_HTML_FOLDER = "html";
    public static bool IGNORE_CACHE = false;
    public static int DOWNLOAD_ATTEMPTS = 4;

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
            var web = new HtmlWeb();
            for (var attempt = 1; ; attempt++) {
                doc = web.Load(url);
                if (web.StatusCode == System.Net.HttpStatusCode.OK) break;

                // Never cache error pages (e.g. 403 from rate limiting), they would break later runs
                if (attempt >= DOWNLOAD_ATTEMPTS) throw new Exception($"Cannot download {url}: HTTP {(int)web.StatusCode}");
                Thread.Sleep(TimeSpan.FromSeconds(5 * attempt));
            }
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

    // Fix UTF-8 bytes that were misread as Latin-1 (mojibake).
    // Works character-by-character to avoid corrupting already-correctly-decoded chars
    // (e.g. í decoded from &#237; must not be re-processed).
    private static string FixMojibake(string text) {
        var result = new StringBuilder(text.Length);
        for (int i = 0; i < text.Length; i++) {
            char c1 = text[i];
            // A mojibake 2-byte pair: first byte 0xC0–0xFF (Latin-1 upper half),
            // second byte 0x80–0xBF (UTF-8 continuation range).
            if (c1 >= 0xC0 && c1 <= 0xFF && i + 1 < text.Length) {
                char c2 = text[i + 1];
                if (c2 >= 0x80 && c2 <= 0xBF) {
                    var decoded = Encoding.UTF8.GetString([(byte)c1, (byte)c2]);
                    if (decoded.Length == 1 && decoded[0] != '\uFFFD') {
                        result.Append(decoded);
                        i++;
                        continue;
                    }
                }
            }
            result.Append(c1);
        }
        return result.ToString();
    }

    public static string PrefixEachLineSpacesDoc(string el, int indent = 4) {
        return PrefixEachLineSpaces(el, indent, true);
    }

    public static string PrefixEachLineSpaces(string el, int indent = 4, bool includeDocComment = false) {
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

    // Maximal length of doc comment line including indentation and "/// "
    public const int MAX_DOC_LINE = 120;

    private static int DocTextWidth(int indent) => Math.Max(40, MAX_DOC_LINE - indent - "/// ".Length);

    private static bool FitsOnDocLine(string text, int indent) => !text.Contains('\n') && text.Length <= DocTextWidth(indent);

    // Word wrap doc text to MAX_DOC_LINE. Existing line breaks are kept, words longer than the width (urls) are not split.
    public static string WrapDocText(string text, int indent) {
        var width = DocTextWidth(indent);
        List<string> lines = [];

        foreach (var paragraph in text.Split('\n').Select(l => l.Trim())) {
            var line = new StringBuilder();
            foreach (var word in paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries)) {
                if (line.Length > 0 && line.Length + 1 + word.Length > width) {
                    lines.Add(line.ToString());
                    line.Clear();
                }
                if (line.Length > 0) line.Append(' ');
                line.Append(word);
            }
            lines.Add(line.ToString());
        }

        return string.Join('\n', lines);
    }

    // Generate doc comment summary
    public static void GenerateSummary(string summary, int indent, List<(string, string)> examples, StringBuilder sb, bool useValueElement = false) {
        // Do nothing when summary and Examples are empty
        if (string.IsNullOrEmpty(summary) && examples.Count == 0) return;

        var element = useValueElement ? "value" : "summary";
        var sum = summary
            .Replace("Â", "")
            .Trim();

        //Add single line summary
        if (examples.Count == 0 && FitsOnDocLine($"<{element}>{sum}</{element}>", indent)) {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<{element}>{sum}</{element}>", indent));
            return;
        }

        sb.AppendLine(PrefixEachLineSpacesDoc($"<{element}>", indent));
        if (!string.IsNullOrEmpty(summary)) {
            sb.AppendLine(PrefixEachLineSpacesDoc(WrapDocText(sum, indent), indent));
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
        if (parameters == null || parameters.Count == 0) return;

        parameters
            .Where(x => !string.IsNullOrEmpty(x.Item2))
            .ToList()
            .ForEach(param => {
                sb.AppendLine(PrefixEachLineSpacesDoc($"<param name=\"{param.Item1}\">{param.Item2}</param>", indent));
            });
    }

    // Generate member definition
    public static void GenerateDefinition(string definition, MemberDefinitionType type, int indent, StringBuilder sb, List<string> fields = null) {
        sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(definition), indent));

        var append = string.Empty;

        switch (type) {
            case MemberDefinitionType.Enum:
                if (fields != null && fields.Count == 0) {
                    sb.Append(" { }");
                    break;
                }

                sb.AppendLine(" {");
                fields.Sort((a, b) => {
                    var aNum = int.Parse(a.Split('=')[1].Trim().TrimEnd(',').Trim());
                    var bNum = int.Parse(b.Split('=')[1].Trim().TrimEnd(',').Trim());

                    return aNum.CompareTo(bNum);
                });

                fields.ForEach(f => {
                    sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(f), indent * 2));
                    sb.AppendLine(",");
                });

                sb.Append(PrefixEachLineSpaces("}", indent));
                break;
            case MemberDefinitionType.PropertyOrFieldOrEvent:
                if (!definition.EndsWith('}')) append = ";";
                break;
            case MemberDefinitionType.Method:
                if (!definition.EndsWith(';')) append = " { throw new NotImplementedException(); }";
                break;
            case MemberDefinitionType.Constructor:
                append = " { }";
                break;
            default:
                append = " { }";
                break;
        }

        if (string.IsNullOrEmpty(append)) return;

        sb.Append(append);
    }

    // Generates doc comment returns
    public static void GenerateSingleOrMultiLineElement(string val, int indent, string elementName, StringBuilder sb) {
        if (string.IsNullOrEmpty(val)) return;

        if (!FitsOnDocLine($"<{elementName}>{val}</{elementName}>", indent)) {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<{elementName}>", indent));
            sb.AppendLine(PrefixEachLineSpacesDoc(WrapDocText(val, indent), indent));
            sb.AppendLine(PrefixEachLineSpacesDoc($"</{elementName}>", indent));
        } else {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<{elementName}>{val}</{elementName}>", indent));
        }
    }
}
