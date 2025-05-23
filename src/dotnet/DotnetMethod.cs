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

        GenerateSummary(Summary, Examples, sb);

        Parameters.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(param => {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<param name=\"{param.Item1}\">{param.Item2}</param>"));
        });

        if (!Remarks.IsNullOrEmpty()) {
            sb.AppendLine(PrefixEachLineSpacesDoc("<remarks>"));
            sb.AppendLine(PrefixEachLineSpacesDoc(ReplaceEndLinesWithSpace(Remarks)));
            sb.AppendLine(PrefixEachLineSpacesDoc("</remarks>"));
        }

        Exceptions.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(ex => {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<exception cref=\"{ex.Item1}\">"));
            sb.AppendLine(PrefixEachLineSpacesDoc(ex.Item2));
            sb.AppendLine(PrefixEachLineSpacesDoc("</exception>"));
        });

        if (!Returns.IsNullOrEmpty()) {
            sb.AppendLine(PrefixEachLineSpacesDoc("<returns>"));
            sb.AppendLine(PrefixEachLineSpacesDoc(ReplaceEndLinesWithSpace(Returns)));
            sb.AppendLine(PrefixEachLineSpacesDoc("</returns>"));
        }

        if (!FullUrl.IsNullOrEmpty()) {
            sb.AppendLine(PrefixEachLineSpacesDoc($"<see href=\"{FullUrl}\"/>", indent));
        }

        var def = SanitizeXmlToString(Definition);
        if (!Definition.EndsWith(';')) def += " { throw new NotImplementedException(); }";

        sb.Append(PrefixEachLineSpaces(def, indent));

        return sb.ToString();
    }
}
