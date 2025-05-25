using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetMethod() {
    public string Name { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
    public string FullUrl { get; set; } = string.Empty;
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

        GenerateSingleOrMultiLineElement(Returns, indent, "remarks", sb);

        Exceptions.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(ex => {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<exception cref=\"{ex.Item1}\">"));
            sb.AppendLine(PrefixEachLineSpacesDoc(ex.Item2));
            sb.AppendLine(PrefixEachLineSpacesDoc("</exception>"));
        });

        GenerateSingleOrMultiLineElement(Returns, indent, "returns", sb);

        sb.Append(PrefixEachLineSpaces(SanitizeXmlToString(Definition), indent));
        if (!Definition.EndsWith(';')) sb.Append(" { throw new System.NotImplementedException(); }");

        // sb.Append(PrefixEachLineSpaces(def, indent));

        return sb.ToString();
    }
}
