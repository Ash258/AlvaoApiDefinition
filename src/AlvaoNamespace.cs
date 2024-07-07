using System.Text;
using HtmlAgilityPack;

namespace AlvaoScapper;

public class AlvaoNamespace
{
    public string Name { get; set; }
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public string Folder { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public AlvaoClass[]? Classes { get; set; }

    public AlvaoNamespace(string fullUrl, string name)
    {
        Name = name;
        FullUrl = fullUrl;
        LocalHtmlFile = $"{Helpers.LOCAL_HTML_FOLDER}/{fullUrl.Split("/").Last()}";
        Folder = $"{Name.Replace(".", "/")}";
        HtmlDocument = Helpers.LoadDocument(fullUrl, LocalHtmlFile);

        if (!Directory.Exists(Folder)) Directory.CreateDirectory(Folder);
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
            var _summary = Helpers.GetSummary(enumDocument);
            if (_summary.Contains("Obsolete") || _summary.Contains("obsolete")) continue;
            var sb = new StringBuilder();
            if (!_summary.Equals("")) sb.AppendLine(_summary);
            sb.AppendLine(Helpers.GenerateSeeDoc(enumLink));

            var enumDef = Helpers.ExtractObjectDefinition(enumDocument);
            if (enumDef == null) continue;
            enumDef = Helpers.SanitizeXmlToString(enumDef);

            var members = enumDocument.DocumentNode.SelectNodes("//table[@id='enumMemberList']/tr");

            sb.AppendLine(enumDef);
            sb.AppendLine("{");
            foreach (var m in members.TakeLast(members.Count - 1))
            {
                var name = m.SelectSingleNode(".//td[1]").InnerText.Trim();
                var value = m.SelectSingleNode(".//td[2]").InnerText.Trim();
                if (value.Contains(',')) value = value.Replace(",", "_");
                sb.AppendLine($"    {name} = {value},");
            }
            sb.AppendLine("}");

            // It is class level enum
            if (enumName.Contains('.'))
            {
                var key = $"{Name}.{enumName.Split(".").First()}";
                var clazzToUpdate = State.Classes.FirstOrDefault(el => el.Key.Equals(key)).Value;
                if (clazzToUpdate == null) continue;

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
