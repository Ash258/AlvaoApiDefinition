using System.Data.Common;
using System.Text;

namespace AlvaoScrapper;

public record DotnetProperty()
{
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Definition { get; set; }

    public string Produce(int indent = 4)
    {
        var sb = new StringBuilder();
        if (!Summary.IsNullOrEmpty())
        {
            sb.Append(Helpers2.PrefixEachLineSpaces($"///<value>{Summary}</value>", indent));
        }
        sb.Append(Helpers2.PrefixEachLineSpaces(Definition + ";", indent));

        return sb.ToString();
    }

    public void Reset()
    {
        Name = string.Empty;
        Summary = string.Empty;
        Definition = string.Empty;
    }
}
