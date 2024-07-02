using System.Text;
using Alvao.API.Common.Model.Database;
using HtmlAgilityPack;
using Microsoft.Extensions.Primitives;

namespace AlvaoScapper;

public class AlvaoClass
{
    public string NamespaceName { get; set; }
    public string Name { get; set; }
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public string Definition { get; set; } = "";
    public bool TableAttributeUsing { get; set; } = false;

    public Dictionary<string, string>? Constructors { get; set; }
    public Dictionary<string, string>? Properties { get; set; }
    public Dictionary<string, string>? Methods { get; set; }
    public Dictionary<string, string>? Fields { get; set; }

    public AlvaoClass(string fullUrl, string localHtmlFile, string namespaceName, string name)
    {
        FullUrl = fullUrl;
        LocalHtmlFile = localHtmlFile;
        NamespaceName = namespaceName;
        Name = name;
        HtmlDocument = Helpers.LoadDocument(fullUrl, localHtmlFile);
    }

    public void Process()
    {
        Definition = HtmlDocument.DocumentNode.SelectSingleNode("//div[@id='IDAB_code_Div1']").InnerText.Trim();
        // TODO: Process constructors
        // TODO: Process properties
        // TODO: Process methods
        // TODO: Process fields

        ProduceFinalCsFile();
    }

    public void ProduceFinalCsFile()
    {
        var sb = new StringBuilder();

        // TODO: Handle usings
        if (TableAttributeUsing)
        {
            sb.AppendLine("");
            sb.AppendLine("using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;");
            sb.AppendLine("");
        }

        sb.AppendLine($"namespace {NamespaceName};");
        sb.AppendLine("");
        sb.AppendLine($"{Definition} {{");
        sb.AppendLine("}");

        Console.WriteLine(sb.ToString());
    }
}
