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

        GenerateSummary(Summary, indent, Examples, sb);
        GenerateSeeUrl(FullUrl, indent, sb);
        GenerateParameters(Parameters, indent, sb);

        sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(Definition) + " {}", indent));

        return sb.ToString();
    }
}
