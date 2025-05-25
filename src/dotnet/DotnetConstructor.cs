using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetConstructor() : DotnetBase {
    public List<(string, string)> Parameters { get; set; } = []; // Just name and summary of parameters for now
    public List<(string, string)> Examples { get; set; } = [];

    public string Produce(int indent = 4) {
        var sb = new StringBuilder();

        GenerateSummary(Summary, indent, Examples, sb);
        GenerateSeeUrl(FullUrl, indent, sb);
        GenerateParameters(Parameters, indent, sb);
        GenerateDefinition(Definition, MemberDefinitionType.Constructor, indent, sb);

        return sb.ToString();
    }
}
