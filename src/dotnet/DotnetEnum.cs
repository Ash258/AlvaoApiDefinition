using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetEnum() {
    public string Name { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
    public string FullUrl { get; set; } = string.Empty;
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
