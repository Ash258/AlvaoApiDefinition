using HtmlAgilityPack;

namespace AlvaoScapper;

public static class Helpers
{
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
}
