using System.Text;
using HtmlAgilityPack;

namespace AlvaoScapper;

public class AlvaoNamespace
{
    public string Name { get; set; }
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public string Folder { get; set; }
    public string FQDN { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public AlvaoClass[]? Classes { get; set; }

    public AlvaoNamespace(string fullUrl, string localHtmlFile, string fQDN, string name)
    {
        Name = name;
        FullUrl = fullUrl;
        LocalHtmlFile = localHtmlFile;
        FQDN = fQDN;
        Folder = $"{Name.Replace(".", "/")}";
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

        var enums = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"enumerationList\"]/tr/td[2]/a");
        if (enums == null) return;

        foreach (var e in enums)
        {
            var enumName = Helpers.ExtractObjectName(e);
            Console.WriteLine($"  Processing {enumName} Enum");

            var enumHtmlBaseFileName = e.GetAttributeValue("href", "").Split("/").Last();
            var enumLink = $"{Helpers.BASE_HTML_URL}/{enumHtmlBaseFileName}";
            var enumLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{enumHtmlBaseFileName}";
            if (!enumLink.StartsWith("https://doc.alvao")) continue;

            var enumDocument = Helpers.LoadDocument(enumLink, enumLocalHtml);

            var enumDef = enumDocument.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']")?.InnerText.Trim();
            if (enumDef == null) continue;
            enumDef = enumDef.Replace("&lt;", "<").Replace("&gt;", ">");

            var members = enumDocument.DocumentNode.SelectNodes("//table[@id='enumMemberList']/tr");

            var sb = new StringBuilder();
            sb.AppendLine($"namespace {Name};");
            sb.AppendLine("");
            sb.AppendLine(enumDef);
            sb.AppendLine("{");
            foreach (var m in members.TakeLast(members.Count - 1))
            {
                var name = m.SelectSingleNode(".//td[1]").InnerText.Trim();
                var value = m.SelectSingleNode(".//td[2]").InnerText.Trim();
                sb.AppendLine($"{name} = {value},");
            }
            sb.AppendLine("}");

            File.WriteAllText($"{Folder}/{enumName}.cs", sb.ToString());
        }
    }
}
