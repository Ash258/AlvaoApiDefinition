using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetField() {
    public string Name { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;

    public string Produce(int indent = 4) {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty()) {
            sb.Append(PrefixEachLineSpaces($"///<value>{Summary}</value>", indent));
            sb.AppendLine("");
        }

        string def = SanitizeXmlToString(Definition);
        def = def.Replace("[Ignore]", "//[Ignore] // ! TODO: Investigate where this come from");

        if (!Definition.EndsWith('}')) def += ";";

        sb.Append(PrefixEachLineSpaces(def, indent));

        return sb.ToString();
    }
}
