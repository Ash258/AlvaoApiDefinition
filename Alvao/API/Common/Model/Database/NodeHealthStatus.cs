using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object health status</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatus.html"/>
[Table("dbo.NodeHealthStatus")]
public class NodeHealthStatus {
    /// <summary>Status description</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatus.html#Alvao_API_Common_Model_Database_NodeHealthStatus_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Health status ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatus.html#Alvao_API_Common_Model_Database_NodeHealthStatus_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
