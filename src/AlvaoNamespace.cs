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

        if (!Directory.Exists(Folder))
        {
            Directory.CreateDirectory(Folder);
        }
    }

    internal void Process()
    {
        ProcessClases();
        ProcessEnums();
    }

    private void ProcessEnums()
    {
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
            if (!enumLink.EndsWith(".htm")) continue;

            var enumDocument = Helpers.LoadDocument(enumLink, enumLocalHtml);

            var enumDef = enumDocument.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']")?.InnerText.Trim();
            if (enumDef == null) continue;
            enumDef = enumDef.Replace("&lt;", "<").Replace("&gt;", ">");

            var members = enumDocument.DocumentNode.SelectNodes("//table[@id='enumMemberList']/tr");
            var sb = new StringBuilder();

            sb.AppendLine(enumDef);
            sb.AppendLine("{");
            foreach (var m in members.TakeLast(members.Count - 1))
            {
                var name = m.SelectSingleNode(".//td[1]").InnerText.Trim();
                var value = m.SelectSingleNode(".//td[2]").InnerText.Trim();
                if (value.Contains(",")) value = value.Replace(",", "_");
                sb.AppendLine($"    {name} = {value},");
            }
            sb.AppendLine("}");

            // It is class level enum
            if (enumName.Contains('.'))
            {
                var key = $"{Name}.{enumName.Split(".").First()}";
                var clazzToUpdate = State.Classes.FirstOrDefault(el => el.Key.Equals(key)).Value;
                if (clazzToUpdate == null)
                {
                    continue;
                }

                clazzToUpdate.Enums.Add(sb.ToString());
                clazzToUpdate.ProduceFinalCsFile();
            }
            else
            {
                sb.Insert(0, Environment.NewLine);
                sb.Insert(0, Environment.NewLine);
                sb.Insert(0, $"namespace {Name};");

                File.WriteAllText($"{Folder}/{enumName}.cs", sb.ToString());
            }
        }
    }

    private void ProcessClases()
    {
        var classes = HtmlDocument.DocumentNode.SelectNodes("//*[@id=\"tocNav\"]/div[@class='toclevel2']");
        if (classes == null) return;

        foreach (var cl in classes)
        {
            AlvaoClass.ProcessClass(cl, this);
        }
    }
}
