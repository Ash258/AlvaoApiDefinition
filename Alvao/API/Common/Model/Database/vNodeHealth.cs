using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Current health of objects.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodeHealth.htm"/>
[TableAttribute("dbo.vNodeHealth")]
public class vNodeHealth
{
    /// <summary>Object health status ID (NodeHealthStatus.id).</summary>
    public virtual int? NodeHealthStatusId { get; set; }
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    public virtual int? NodeId { get; set; }

    public vNodeHealth() { }
}
