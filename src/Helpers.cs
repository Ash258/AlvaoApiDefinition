using System.Text;
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

    public static string TrimEndNewLine(string el)
    {
        return el.TrimEnd().TrimEnd('\n').TrimEnd('\r').TrimEnd('\n').TrimEnd('\r');
    }

    public static string PrefixEachLineSpaces(string el)
    {
        return el.Contains('\n')
            ? TrimEndNewLine(el.Split('\n').Select(x => $"    {TrimEndNewLine(x)}").ToArray().JoinAsString("\n"))
            : TrimEndNewLine($"    {el}");
    }

    private static string ExtractLanguageSpecificValue(HtmlAttribute attr)
    {
        return attr.Value.Split("|").FirstOrDefault(pair => pair.StartsWith("cs="), "").Split("=").Last();
    }

    // Extract value of languagespecifictext data attribute or inner text
    private static string ExtractLanguageSpecificValue(HtmlNode node)
    {
        var attr = node.GetDataAttribute("languagespecifictext");
        if (attr != null)
        {
            var val = ExtractLanguageSpecificValue(attr);
            return val;
        }
        else
        {
            return node.InnerText;
        }
    }

    public static string? ExtractMethodDef(HtmlDocument document)
    {
        var node = document.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']");
        if (node == null) return null;

        if (!node.HasChildNodes) return SanitizeXmlToString(node.InnerText);

        foreach (var ch in node.ChildNodes.Where(el => el.OriginalName.Equals("pre")))
        {
            Console.WriteLine($"A: {ch.ChildNodes}");
        }

        return SanitizeXmlToString(node.InnerText);
    }

    public static string ExtractObjectName(HtmlNode node)
    {
        string name;

        if (node.InnerHtml.Contains("data-languagespecifictext="))
        {
            var sb = new StringBuilder();
            foreach (var ch in node.ChildNodes)
            {
                switch (ch.Name)
                {
                    case "#text":
                        sb.Append(ch.InnerText);
                        break;
                    case "span":
                        sb.Append(ExtractLanguageSpecificValue(ch));
                        break;
                }
            }

            name = sb.ToString();
        }
        else
        {
            name = node.InnerText;
        }

        return Regex.Replace(name, @"\r?\n\s+", " ");
    }

    public static string? ExtractObjectDefinition(HtmlDocument node)
    {
        var nodeDef = node.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']/pre");
        if (nodeDef == null)
        {
            nodeDef = node.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']");
            if (nodeDef == null) return null;
        }

        string definition;

        if (nodeDef.InnerHtml.Contains("data-languagespecifictext="))
        {
            var sb = new StringBuilder();
            foreach (var ch in nodeDef.ChildNodes)
            {
                switch (ch.Name)
                {
                    case "#text":
                        sb.Append(ch.InnerText);
                        break;
                    case "span":
                        if (ch.ChildNodes.Count > 1)
                        {

                            foreach (var nestedChild in ch.ChildNodes)
                            {
                                string _val = "";
                                switch (nestedChild.Name)
                                {
                                    case "#text":
                                        _val = nestedChild.InnerText;
                                        break;
                                    case "span":
                                        _val = ExtractLanguageSpecificValue(nestedChild);
                                        break;
                                }
                                sb.Append(_val);
                            }
                        }
                        else
                        {
                            sb.Append(ch.InnerText);
                        }
                        break;
                }
            }

            definition = sb.ToString();
        }
        else
        {
            definition = nodeDef.InnerText;
        }

        return SanitizeXmlToString(definition);
    }

    internal static bool IsClass(AlvaoClass clazz, string namespaceName, string className)
    {
        return clazz.NamespaceName.Equals(namespaceName) && clazz.Name.Equals(className);
    }
}
