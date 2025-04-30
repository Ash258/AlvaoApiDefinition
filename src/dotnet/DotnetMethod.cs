using System.Text;

namespace AlvaoScrapper;

public record DotnetMethod()
{
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Definition { get; set; }
    public List<(string, string)> Parameters { get; set; } // Just name and summary of parameters for now
    public string Returns { get; set; }

    public string Produce(int indent = 4)
    {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty())
        {
            sb.Append(Helpers2.PrefixEachLineSpaces($"///<value>{Summary}</value>", indent));
            sb.AppendLine("");
        }

        if (!Returns.IsNullOrEmpty())
        {
            sb.Append(Helpers2.PrefixEachLineSpaces($"///<returns>"));
            sb.Append(Helpers2.PrefixEachLineSpaces(Returns));
            sb.Append(Helpers2.PrefixEachLineSpaces($"///</returns>"));
            sb.AppendLine();
        }

        if (Parameters.Count > 0)
        {
            Parameters.Where(x => !string.IsNullOrEmpty(x.Item2)).ToList().ForEach(param =>
            {
                sb.Append(Helpers2.PrefixEachLineSpaces($"///<param name=\"{param.Item1}\">{param.Item2}</param>"));
                sb.AppendLine();
            });
        }

        sb.Append(Helpers2.PrefixEachLineSpaces(Helpers2.SanitizeXmlToString(Definition) + " { throw new NotImplementedException(); }", indent));

        return sb.ToString();
    }

    public void Reset()
    {
        Name = string.Empty;
        Summary = string.Empty;
        Definition = string.Empty;
        Parameters = [];
        Returns = string.Empty;
    }
}
