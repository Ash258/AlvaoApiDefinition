using System.Text;

namespace AlvaoScrapper;

public record DotnetConstructor()
{
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Definition { get; set; }
    public List<(string, string)> Parameters { get; set; } // Just name and summary of parameters for now
    public List<string> Examples { get; set; }

    public string Produce(int indent = 4)
    {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty())
        {
            sb.Append(Helpers2.PrefixEachLineSpaces($"///<value>{Summary}</value>", indent));
            sb.AppendLine("");
        }

        if (Parameters.Count > 0)
        {
            Parameters.ForEach(param =>
            {
                sb.Append(Helpers2.PrefixEachLineSpaces($"///<param name=\"{param.Item1}\">{param.Item2}</param>"));
                sb.AppendLine();
            });
        }

        if (Examples.Count > 0)
        {
            for (int i = 0; i < Examples.Count; ++i)
            {
                sb.Append(Helpers2.PrefixEachLineSpaces("/// <example>"));
                // sb.Append(Helpers2.PrefixEachLineSpaces($"/// Example {i}"));
                sb.Append(Helpers2.PrefixEachLineSpaces("/// <code>"));
                sb.Append(Helpers2.PrefixEachLineSpaces(Examples[i]));
                sb.Append(Helpers2.PrefixEachLineSpaces("/// </code>"));
                // sb.Append(Helpers2.PrefixEachLineSpaces($"/// results in <c>p</c>'s having the value (2,8)."));
                sb.Append(Helpers2.PrefixEachLineSpaces("/// </example>"));
            }
        }

        sb.Append(Helpers2.PrefixEachLineSpaces(Helpers2.SanitizeXmlToString(Definition) + " {}", indent));

        return sb.ToString();
    }

    public void Reset()
    {
        Name = string.Empty;
        Summary = string.Empty;
        Definition = string.Empty;
        Parameters = [];
    }
}
