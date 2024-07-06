using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Custom extension of the object health calculation. You can edit this view. By default, it does not contain///           any records.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodeHealth_Custom.htm"/>
[TableAttribute("dbo.vNodeHealth_Custom")]
public class vNodeHealth_Custom
{
    /// <summary>Object health status ID (NodeHealthStatus.id).</summary>
    public virtual int? NodeHealthStatusId { get; set; }
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    public virtual int? NodeId { get; set; }

    public vNodeHealth_Custom() { }
}
