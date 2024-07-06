using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Object health status
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NodeHealthStatus.htm"/>
[TableAttribute("dbo.NodeHealthStatus")]
public class NodeHealthStatus
{
    /// <summary>Status description</summary>
    public virtual string Description { get; set; }
    /// <summary>Health status ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public NodeHealthStatus() { }
}
