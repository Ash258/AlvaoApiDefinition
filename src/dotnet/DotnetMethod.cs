using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetMethod() : DotnetBase {
    public List<(string, string)> Parameters { get; set; } = []; // Just name and summary of parameters for now
    public List<(string, string)> Exceptions { get; set; } = [];
    public List<(string, string)> Examples { get; set; } = [];
    public string Returns { get; set; } = string.Empty;
    public string Remarks { get; set; } = string.Empty;

    public string Produce(int indent = 4) {
        var sb = new StringBuilder();

        GenerateSummary(Summary, indent, Examples, sb);
        GenerateSeeUrl(FullUrl, indent, sb);
        GenerateParameters(Parameters, indent, sb);

        GenerateSingleOrMultiLineElement(Remarks, indent, "remarks", sb);

        Exceptions.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(ex => {
            sb.Append(PrefixEachLineSpacesDoc($"<exception cref=\"{ex.Item1}\">"));

            if (ex.Item2.Contains('\n')) {
                sb.AppendLine();
                sb.AppendLine(PrefixEachLineSpacesDoc(ex.Item2));
                sb.AppendLine(PrefixEachLineSpacesDoc("</exception>"));
            } else {
                sb.AppendLine($"{ex.Item2}</exception>");
            }
        });

        GenerateSingleOrMultiLineElement(Returns, indent, "returns", sb);
        GenerateDefinition(Definition, MemberDefinitionType.Method, indent, sb);

        return sb.ToString();
    }
}
