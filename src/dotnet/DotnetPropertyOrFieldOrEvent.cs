using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetPropertyOrFieldOrEvent() : DotnetBase {
    public string Remarks { get; set; } = string.Empty;

    public string Produce(int indent = 4) {
        var sb = new StringBuilder();

        GenerateSummary(Summary, indent, [], sb);
        GenerateSeeUrl(FullUrl, indent, sb);
        GenerateSingleOrMultiLineElement(Remarks, indent, "remarks", sb);
        GenerateDefinition(Definition, MemberDefinitionType.PropertyOrFieldOrEvent, indent, sb);

        return sb.ToString();
    }
}
