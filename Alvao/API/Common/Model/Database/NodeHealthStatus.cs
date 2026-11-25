using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object health status</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatus.html"/>
[Table("dbo.NodeHealthStatus")]
public class NodeHealthStatus {
    /// <summary>Status description</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatus.html#Alvao_API_Common_Model_Database_NodeHealthStatus_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>Health status ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatus.html#Alvao_API_Common_Model_Database_NodeHealthStatus_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int id { get; set; }
}
