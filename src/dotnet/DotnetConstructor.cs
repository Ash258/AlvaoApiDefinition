using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetConstructor() {
    public string Name { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
    public List<(string, string)> Parameters { get; set; } = []; // Just name and summary of parameters for now
    public List<string> Examples { get; set; } = [];

    public string Produce(int indent = 4) {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty()) {
            sb.Append(PrefixEachLineSpacesDoc($"<value>{Summary}</value>", indent));
            sb.AppendLine("");
        }

        if (Parameters.Count > 0) {
            Parameters.ForEach(param => {
                sb.Append(PrefixEachLineSpacesDoc($"<param name=\"{param.Item1}\">{param.Item2}</param>"));
                sb.AppendLine();
            });
        }

        if (Examples.Count > 0) {
            for (int i = 0; i < Examples.Count; ++i) {
                sb.Append(PrefixEachLineSpacesDoc("<example>"));
                // sb.Append(PrefixEachLineSpacesDoc($"Example {i}"));
                sb.Append(PrefixEachLineSpacesDoc("<code>"));
                sb.Append(PrefixEachLineSpaces(Examples[i]));
                sb.Append(PrefixEachLineSpacesDoc("</code>"));
                // sb.Append(PrefixEachLineSpacesDoc($"results in <c>p</c>'s having the value (2,8)."));
                sb.Append(PrefixEachLineSpacesDoc("</example>"));
            }
        }

        sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(Definition) + " {}", indent));

        return sb.ToString();
    }
}
