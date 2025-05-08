using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;

namespace AlvaoScrapper;

public static class Helpers2
{
    public static ILogger<T> CreateLogger<T>(string filterName = "AlvaoScrapper", string envName = "Logging__LogLevel__AlvaoScrapper", string defaultValue = "4")
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(filterName, (LogLevel)int.Parse(Environment.GetEnvironmentVariable(envName) ?? defaultValue));
            builder.AddSimpleConsole(options =>
            {
                options.IncludeScopes = true;
                options.SingleLine = true;
            });
        });

        return loggerFactory.CreateLogger<T>();
    }

    public static string TrimInnerText(HtmlNode node)
    {
        return node.InnerText.Trim();
    }

    public static string ReplaceEndLinesWithSpace(string el)
    {
        return Regex.Replace(el, @"\r?\n\s*", " ");
    }









    // TODO: Reorganize and verify everything is needed
    public static string GetSummary(HtmlDocument _document)
    {
        var _s = _document.DocumentNode.SelectSingleNode("//article/div[@class='markdown summary']")?.InnerText.Trim();
        if (_s == null) return "";

        return ReplaceEndLinesWithSpace(_s);
    }

    public static string? ExtractObjectDefinition(HtmlDocument node)
    {
        var nodeDef = node.DocumentNode.SelectSingleNode("//div[contains(@class, 'codewrapper')][following::dl[contains(@class, 'typelist') and contains(@class, 'inheritance')]]");
        // If there are none inherited properties, just try with first codewrapper
        if (nodeDef == null)
        {
            nodeDef = node.DocumentNode.SelectSingleNode("//div[contains(@class, 'codewrapper')][1]");
            if (nodeDef == null) return null;
        }

        var def = SanitizeXmlToString(nodeDef.InnerText.Trim());
        return def;
    }

    public static string SanitizeXmlToString(string el)
    {
        return el
            .Replace("&lt;", "<")
            .Replace("&gt;", ">")
            .Replace("&nbsp;", " ")
            .Replace("&quot;", "\"")
            .Trim();
    }

    internal static string PrefixEachLineSpaces(string el, int indent = 4)
    {
        var ind = new string(' ', indent);
        return el.Contains('\n')
            ? TrimEndNewLine(el.Split('\n').Select(x => $"{ind}{TrimEndNewLine(x)}").ToArray().JoinAsString("\n"))
            : TrimEndNewLine($"{ind}{el}");
    }

    public static string TrimEndNewLine(string el)
    {
        return el.TrimEnd().TrimEnd('\n').TrimEnd('\r').TrimEnd('\n').TrimEnd('\r');
    }

    internal static bool IsClass(AlvaoClass2 clazz, string namespaceName, string className)
    {
        return clazz.NamespaceName.Equals(namespaceName) && clazz.Name.Equals(className);
    }
}
