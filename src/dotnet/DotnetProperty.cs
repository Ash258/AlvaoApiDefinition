using System.Text;

namespace AlvaoScrapper;

public record DotnetProperty()
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
        if (!Definition.EndsWith('}'))
        {
            Console.WriteLine("========> definition without  }<===========");
            // sb.Append(Helpers2.PrefixEachLineSpaces(Definition + ";", indent));
        }

        string def = Helpers2.SanitizeXmlToString(Definition);
        def = def.Replace("[Ignore]", "//[Ignore] // ! TODO: Investigate where this come from");
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
