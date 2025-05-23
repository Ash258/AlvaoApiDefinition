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

        if (!Summary.IsNullOrEmpty() || Examples.Count > 0) {
            sb.AppendLine(PrefixEachLineSpacesDoc("<summary>", indent));
            if (!Summary.IsNullOrEmpty()) {
                sb.AppendLine(PrefixEachLineSpacesDoc(Summary.Trim(), indent));
            }

            Examples.ForEach(x => {
                sb.AppendLine(PrefixEachLineSpacesDoc("<example>"));
                // sb.AppendLine(PrefixEachLineSpacesDoc($"Example {i}"));
                sb.AppendLine(PrefixEachLineSpacesDoc("<code>"));
                sb.AppendLine(PrefixEachLineSpacesDoc(x));
                sb.AppendLine(PrefixEachLineSpacesDoc("</code>"));
                // sb.AppendLine(PrefixEachLineSpacesDoc($"results in <c>p</c>'s having the value (2,8)."));
                sb.AppendLine(PrefixEachLineSpacesDoc("</example>"));

            });

            sb.AppendLine(PrefixEachLineSpacesDoc("</summary>", indent));
        }

        Parameters.ForEach(param => {
            sb.Append(PrefixEachLineSpacesDoc($"<param name=\"{param.Item1}\">{param.Item2}</param>"));
            sb.AppendLine();
        });

        sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(Definition) + " {}", indent));

        return sb.ToString();
    }
}
