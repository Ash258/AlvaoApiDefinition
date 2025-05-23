using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetConstructor() {
    public string Name { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
    public string FullUrl { get; set; } = string.Empty;
    public List<(string, string)> Parameters { get; set; } = []; // Just name and summary of parameters for now
    public List<(string, string)> Examples { get; set; } = [];

    public string Produce(int indent = 4) {
        var sb = new StringBuilder();

        GenerateSummary(Summary, Examples, sb);

        Parameters.ForEach(param => {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<param name=\"{param.Item1}\">{param.Item2}</param>"));
        });

        if (!FullUrl.IsNullOrEmpty()) {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<see href=\"{FullUrl}\"/>", indent));
        }

        sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(Definition) + " {}", indent));

        return sb.ToString();
    }
}
