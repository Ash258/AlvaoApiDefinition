using HtmlAgilityPack;

namespace AlvaoScapper;

public class AlvaoNamespace
{
    public string Name { get; set; }
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public string FQDN { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public AlvaoClass[]? Classes { get; set; }

    public AlvaoNamespace(string fullUrl, string localHtmlFile, string fQDN, string name)
    {
        Name = name;
        FullUrl = fullUrl;
        LocalHtmlFile = localHtmlFile;
        FQDN = fQDN;
        HtmlDocument = Helpers.LoadDocument(fullUrl, localHtmlFile);
    }

    internal void Process()
    {
        var classes = HtmlDocument.DocumentNode.SelectNodes("//*[@id=\"tocNav\"]/div[@class='toclevel2']");

        foreach (var cl in classes)
        {
            var classANode = cl.SelectNodes(".//a").Last();
            var classHtmlBaseFileName = classANode.GetAttributeValue("href", "").Split("/").Last();
            var classLink = $"{Helpers.BASE_HTML_URL}/{classHtmlBaseFileName}";
            var className = classANode.GetAttributeValue("title", "");

            // TODO: Support more types
            if (!className.EndsWith("Class")) continue;

            var clazz = new AlvaoClass(
                classLink,
                $"{Helpers.LOCAL_HTML_FOLDER}/{classHtmlBaseFileName}",
                Name,
                className.Replace("Class", "").Trim()
            );
            clazz.Process();
        }
    }
}
