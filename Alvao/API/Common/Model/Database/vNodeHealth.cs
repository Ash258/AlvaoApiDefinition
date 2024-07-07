using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Current health of objects.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodeHealth.htm"/>
[TableAttribute("dbo.vNodeHealth")]
public class vNodeHealth
{
    /// <summary>Object health status ID (NodeHealthStatus.id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodeHealth_NodeHealthStatusId.htm"/>
    public virtual int? NodeHealthStatusId { get; set; }
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodeHealth_NodeId.htm"/>
    public virtual int? NodeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNodeHealth__ctor.htm"/>
    public vNodeHealth() { }
}
