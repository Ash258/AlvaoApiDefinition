using System.Text;
using HtmlAgilityPack;

namespace AlvaoScapper;

public class AlvaoClass
{
    public string NamespaceName { get; set; }
    public string Name { get; set; }
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public string FinalCsFile { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public string Definition { get; set; } = "";
    public List<string> Usings { get; set; }

    public Dictionary<string, string>? Constructors { get; set; }
    public List<string> Properties { get; set; }
    public List<string> Fields { get; set; }
    public Dictionary<string, string>? Methods { get; set; }

    public AlvaoClass(string fullUrl, string localHtmlFile, string namespaceName, string name)
    {
        Usings = [];
        Fields = [];
        Properties = [];
        FullUrl = fullUrl;
        LocalHtmlFile = localHtmlFile;
        NamespaceName = namespaceName;
        Name = name;
        HtmlDocument = Helpers.LoadDocument(fullUrl, localHtmlFile);
        FinalCsFile = $"{namespaceName.Replace(".", "/")}/{name}.cs";
    }

    public void ProcessProperties()
    {
        var properties = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"PropertyList\"]/tr/td[2]/a");
        if (properties == null) return;

        foreach (var p in properties)
        {
            var propName = p.InnerText;
            Console.WriteLine($"    Processing {propName} Property");

            var propHtmlBaseFileName = p.GetAttributeValue("href", "").Split("/").Last();
            var propLink = $"{Helpers.BASE_HTML_URL}/{propHtmlBaseFileName}";
            var propLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{propHtmlBaseFileName}";
            if (!propLink.StartsWith("https://doc.alvao")) continue;

            var propDocument = Helpers.LoadDocument(propLink, propLocalHtml);
            var propDef = propDocument.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']")?.InnerText.Trim();
            if (propDef == null) continue;
            propDef = propDef.Replace("&lt;", "<").Replace("&gt;", ">");

            if (propDef.Contains("JsonPropertyAttribute(")) Usings.Add("Newtonsoft.Json");

            Properties.Add($"{propDef}");
        }
    }

    public void ProcessFields()
    {
        var fields = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"FieldList\"]/tr/td[2]/a");
        if (fields == null) return;

        foreach (var f in fields)
        {
            var fieldName = f.InnerText;
            Console.WriteLine($"    Processing {fieldName} Field");

            var fieldHtmlBaseFileName = f.GetAttributeValue("href", "").Split("/").Last();
            var fieldLink = $"{Helpers.BASE_HTML_URL}/{fieldHtmlBaseFileName}";
            var fieldLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{fieldHtmlBaseFileName}";
            if (!fieldLink.StartsWith("https://doc.alvao")) continue;

            var fieldDocument = Helpers.LoadDocument(fieldLink, fieldLocalHtml);

            var fieldDef = fieldDocument.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']")?.InnerText.Trim();
            if (fieldDef == null) continue;
            fieldDef = fieldDef.Replace("&lt;", "<").Replace("&gt;", ">");

            if (fieldName.Equals("EmailFormat"))
            {
                fieldDef = fieldDef.Replace("\"]", "\"\"]");
            }
            if (new[] { "EmailFormat", "EmailPattern" }.Contains(fieldName))
            {
                fieldDef = fieldDef.Replace("= \"", "= @\"");
            }

            Fields.Add($"{fieldDef}");
        }
    }

    public void Process()
    {
        Console.WriteLine($"  Processing {Name} Class");
        Definition = HtmlDocument.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']").InnerText.Trim();
        Definition = Definition.Replace("&lt;", "<").Replace("&gt;", ">");

        if (Definition.Contains("TableAttribute(")) Usings.Add("System.ComponentModel.DataAnnotations.Schema");
        if (Definition.Contains(": Profile")) Usings.Add("AutoMapper");
        if (Definition.Contains(": tbl")) Usings.Add("Alvao.API.Common.Model.Database");
        if (Definition.Contains(": vColumnLoc")) Usings.Add("Alvao.API.Common.Model.Database");

        ProcessProperties();
        ProcessFields();
        // TODO: Process constructors
        // TODO: Process properties
        // TODO: Process methods
        // TODO: Process fields

        ProduceFinalCsFile();
    }

    public void ProduceFinalCsFile()
    {
        var sb = new StringBuilder();

        if (Usings.Count != 0) Properties.ForEach(el => sb.AppendLine($"using {el};"));

        sb.AppendLine($"namespace {NamespaceName};");
        sb.AppendLine("");

        sb.AppendLine(Definition);
        sb.AppendLine("{");
        Properties.ForEach(el => sb.AppendLine($"    {el}"));
        Fields.ForEach(el => sb.AppendLine($"    {el};"));
        // TODO: Constructors
        // TODO: Methods
        sb.AppendLine("}");

        File.WriteAllText(FinalCsFile, sb.ToString());
    }
}
