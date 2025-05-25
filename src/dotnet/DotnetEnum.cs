using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetEnum() : DotnetBase {
    public List<string> Fields { get; set; } = [];

    public string Produce(int indent = 4) {
        Definition = Definition.Replace(Name.Split(".")[0] + ".", "");

        var sb = new StringBuilder();

        GenerateSummary(Summary, indent, [], sb);
        GenerateSeeUrl(FullUrl, indent, sb);
        GenerateDefinition(Definition, MemberDefinitionType.Enum, indent, sb, Fields);

        return sb.ToString();
    }
}
