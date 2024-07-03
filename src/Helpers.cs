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
}
