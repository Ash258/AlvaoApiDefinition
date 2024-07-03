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
    public Dictionary<string, string>? Properties { get; set; }
    public Dictionary<string, string>? Methods { get; set; }
    public Dictionary<string, string>? Fields { get; set; }

    public AlvaoClass(string fullUrl, string localHtmlFile, string namespaceName, string name)
    {
        Usings = [];
        FullUrl = fullUrl;
        LocalHtmlFile = localHtmlFile;
        NamespaceName = namespaceName;
        Name = name;
        HtmlDocument = Helpers.LoadDocument(fullUrl, localHtmlFile);
        FinalCsFile = $"{namespaceName.Replace(".", "/")}/{name}.cs";
    }

    public void Process()
    {
        Definition = HtmlDocument.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']").InnerText.Trim();
        Definition = Definition.Replace("&lt;", "<").Replace("&gt;", ">");

        if (Definition.Contains("TableAttribute(")) Usings.Add("using System.ComponentModel.DataAnnotations.Schema;");
        if (Definition.Contains(": Profile")) Usings.Add("using AutoMapper;");
        if (Definition.Contains(": tbl")) Usings.Add("using Alvao.API.Common.Model.Database;");
        if (Definition.Contains(": vColumnLoc")) Usings.Add("using Alvao.API.Common.Model.Database;");

        // TODO: Process constructors
        // TODO: Process properties
        // TODO: Process methods
        // TODO: Process fields

        ProduceFinalCsFile();
    }

    public void ProduceFinalCsFile()
    {
        var sb = new StringBuilder();

        if (Usings.Count != 0)
        {
            Usings.ForEach((element) =>
            {
                sb.AppendLine(element);
            });
            sb.AppendLine("");
        }
        sb.AppendLine($"namespace {NamespaceName};");
        sb.AppendLine("");
        sb.AppendLine(Definition);
        sb.AppendLine("{");
        sb.AppendLine("}");

        Console.WriteLine(sb.ToString());
        File.WriteAllText(FinalCsFile, sb.ToString());
    }
}
