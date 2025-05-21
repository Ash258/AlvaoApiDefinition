using System.Text;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public record DotnetMethod() {
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Definition { get; set; }
    public List<(string, string)> Parameters { get; set; } // Just name and summary of parameters for now
    public List<(string, string)> Exceptions { get; set; }
    public string Returns { get; set; }

    public string Produce(int indent = 4) {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty()) {
            sb.Append(PrefixEachLineSpaces($"///<value>{Summary}</value>", indent));
            sb.AppendLine("");
        }

        if (!Returns.IsNullOrEmpty()) {
            sb.AppendLine(PrefixEachLineSpaces($"///<returns>"));
            sb.AppendLine(PrefixEachLineSpaces($"///{Returns}"));
            sb.AppendLine(PrefixEachLineSpaces($"///</returns>"));
        }

        if (Parameters.Count > 0) {
            Parameters.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(param => {
                sb.Append(PrefixEachLineSpaces($"///<param name=\"{param.Item1}\">{param.Item2}</param>"));
                sb.AppendLine();
            });
        }

        if (Exceptions.Count > 0) {
            Exceptions.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(ex => {
                sb.AppendLine(PrefixEachLineSpaces($"///<exception cref=\"{ex.Item1}\">"));
                sb.AppendLine(PrefixEachLineSpaces($"///{ex.Item2}"));
                sb.AppendLine(PrefixEachLineSpaces($"///</exception>"));
            });
        }

        var def = SanitizeXmlToString(Definition);
        if (!Definition.EndsWith(';')) def += " { throw new NotImplementedException(); }";

        sb.Append(PrefixEachLineSpaces(def, indent));

        return sb.ToString();
    }

    public void Reset() {
        Name = string.Empty;
        Summary = string.Empty;
        Definition = string.Empty;
        Parameters = [];
        Exceptions = [];
        Returns = string.Empty;
    }
}
