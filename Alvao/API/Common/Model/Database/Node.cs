using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>"Objects" in AM.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Node.htm"/>
[TableAttribute("dbo.Node")]
public class Node {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Node_Node_Id.htm"/>
    public virtual int Node_Id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_Node__ctor.htm"/>
    public Node() { }
}
