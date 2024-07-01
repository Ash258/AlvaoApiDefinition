using HtmlAgilityPack;

namespace AlvaoScapper;

public class AlvaoNamespace
{
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public string FQDN { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public AlvaoClass[]? Classes { get; set; }

    public AlvaoNamespace(string fullUrl, string localHtmlFile, string fQDN)
    {
        FullUrl = fullUrl;
        LocalHtmlFile = localHtmlFile;
        FQDN = fQDN;
        HtmlDocument = Helpers.LoadDocument(fullUrl, localHtmlFile);
    }
}
