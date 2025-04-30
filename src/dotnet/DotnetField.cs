using System.Text;

namespace AlvaoScrapper;

public record DotnetField()
{
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Definition { get; set; }

    public string Produce(int indent = 4)
    {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty())
        {
            sb.Append(Helpers2.PrefixEachLineSpaces($"///<value>{Summary}</value>", indent));
            sb.AppendLine("");
        }

        string def = Helpers2.SanitizeXmlToString(Definition);
        def = def.Replace("[Ignore]", "//[Ignore] // ! TODO: Investigate where this come from");

        if (!Definition.EndsWith('}')) def += ";";

        sb.Append(Helpers2.PrefixEachLineSpaces(def, indent));

        return sb.ToString();
    }

    public void Reset()
    {
        Name = string.Empty;
        Summary = string.Empty;
        Definition = string.Empty;
    }
}
