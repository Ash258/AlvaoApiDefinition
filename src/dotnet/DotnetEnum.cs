using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetEnum()
{
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Definition { get; set; }
    public List<string> Fields { get; set; }

    public string Produce(int indent = 4)
    {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty())
        {
            sb.Append(PrefixEachLineSpaces($"///<value>{Summary}</value>", indent));
            sb.AppendLine("");
        }

        Definition = Definition.Replace(Name.Split(".")[0] + ".", "");

        sb.AppendLine(PrefixEachLineSpaces(SanitizeXmlToString(Definition), indent));
        sb.AppendLine(PrefixEachLineSpaces("{", indent));
        // ? TODO: Try to sort the properties
        Fields.ForEach(f => sb.AppendLine(PrefixEachLineSpaces(SanitizeXmlToString(f) + ",", indent * 2)));
        sb.Append(PrefixEachLineSpaces("}", indent));

        return sb.ToString();
    }

    public void Reset()
    {
        Name = string.Empty;
        Summary = string.Empty;
        Fields = [];
    }
}
