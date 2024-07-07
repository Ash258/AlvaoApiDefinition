using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace AlvaoScapper;

public static class Helpers
{
    public static string ALVAO_VERSION = "11_2";
    public static string BASE_URL = $"https://doc.alvao.com/en/alvao_{ALVAO_VERSION}/alvao_api";
    public static string BASE_HTML_URL = $"{BASE_URL}/html";
    public static string LOCAL_HTML_FOLDER = "html";
    public static bool IGNORE_CACHE = false;

    public static HtmlDocument LoadDocument(string url, string localPath)
    {
        HtmlDocument doc = new();
        if (!IGNORE_CACHE && File.Exists(localPath))
        {
            doc.Load(localPath);
        }
        else
        {
            doc = new HtmlWeb().Load(url);
            File.WriteAllText(localPath, doc.Text);
        }

        return doc;
    }


    public static string SanitizeXmlToString(string el)
    {
        return el.Replace("&lt;", "<").Replace("&gt;", ">").Trim();
    }

    // TODO: Rework
    internal static string ExtractObjectName(HtmlNode node)
    {
        var name = "";
        if (node.HasChildNodes)
        {
            var span = node.SelectSingleNode(".//span")?.GetAttributeValue("data-languagespecifictext", ".");
            if (span != null)
            {
                var dot = span.Split("|").FirstOrDefault(pair => pair.StartsWith("cs="), "").Split("=").Last();
                name = Regex.Replace(node.InnerHtml, "<span.*</span>", dot);
            }
            else
            {
                name = node.InnerText;
            }
        }
        else
        {
            name = node.InnerText;
        }

        return SanitizeXmlToString(name);
    }

    internal static string TrimEndNewLine(string el)
    {
        return el.TrimEnd().TrimEnd('\n').TrimEnd('\r').TrimEnd('\n').TrimEnd('\r');
    }

    internal static string PrefixEachLineSpaces(string el)
    {
        return el.Contains('\n')
            ? TrimEndNewLine(el.Split('\n').Select(x => $"    {TrimEndNewLine(x)}").ToArray().JoinAsString("\n"))
            : TrimEndNewLine($"    {el}");
    }
}
