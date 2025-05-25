using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Custom extension of the object health calculation. You can edit this view. By default, it does not contain any records.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeHealth_Custom.html"/>
[Table("dbo.vNodeHealth_Custom")]
public class vNodeHealth_Custom {
    /// <summary>Object health status ID (NodeHealthStatus.id).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeHealth_Custom.html#Alvao_API_Common_Model_Database_vNodeHealth_Custom_NodeHealthStatusId"/>
    public virtual int? NodeHealthStatusId { get; set; }
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeHealth_Custom.html#Alvao_API_Common_Model_Database_vNodeHealth_Custom_NodeId"/>
    public virtual int? NodeId { get; set; }
}
