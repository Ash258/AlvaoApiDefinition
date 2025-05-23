using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetMethod() {
    public string Name { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
    public List<(string, string)> Parameters { get; set; } = []; // Just name and summary of parameters for now
    public List<(string, string)> Exceptions { get; set; } = [];
    public List<(string, string)> Examples { get; set; } = [];
    public string Returns { get; set; } = string.Empty;
    public string Remarks { get; set; } = string.Empty;

    public string Produce(int indent = 4) {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty()) {
            sb.Append(PrefixEachLineSpaces($"///<summary>{Summary}</summary>", indent));
            sb.AppendLine("");
        }

        if (!Returns.IsNullOrEmpty()) {
            sb.AppendLine(PrefixEachLineSpaces($"///<returns>"));
            sb.AppendLine(PrefixEachLineSpaces($"///{ReplaceEndLinesWithSpace(Returns)}"));
            sb.AppendLine(PrefixEachLineSpaces($"///</returns>"));
        }

        if (!Remarks.IsNullOrEmpty()) {
            sb.AppendLine(PrefixEachLineSpaces($"///<remarks>"));
            sb.AppendLine(PrefixEachLineSpaces($"///{ReplaceEndLinesWithSpace(Remarks)}"));
            sb.AppendLine(PrefixEachLineSpaces($"///</remarks>"));
        }

        Parameters.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(param => {
            sb.Append(PrefixEachLineSpaces($"///<param name=\"{param.Item1}\">{param.Item2}</param>"));
            sb.AppendLine();
        });

        Exceptions.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(ex => {
            sb.AppendLine(PrefixEachLineSpaces($"///<exception cref=\"{ex.Item1}\">"));
            sb.AppendLine(PrefixEachLineSpaces($"///{ex.Item2}"));
            sb.AppendLine(PrefixEachLineSpaces($"///</exception>"));
        });

        Examples.ForEach(x => {
            sb.AppendLine(PrefixEachLineSpaces("///<example>"));
            sb.AppendLine(PrefixEachLineSpaces("///<code>"));
            sb.AppendLine(PrefixEachLineSpaces(x.Item2));
            sb.AppendLine(PrefixEachLineSpaces("///</code>"));
            sb.AppendLine(PrefixEachLineSpaces("///</example>"));
        });

        var def = SanitizeXmlToString(Definition);
        if (!Definition.EndsWith(';')) def += " { throw new NotImplementedException(); }";

        sb.Append(PrefixEachLineSpaces(def, indent));

        return sb.ToString();
    }
}
