using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// "Objects" in AM.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Node.htm"/>
[TableAttribute("dbo.Node")]
public class Node
{
    public virtual int Node_Id { get; set; }

    public Node() { }
}
