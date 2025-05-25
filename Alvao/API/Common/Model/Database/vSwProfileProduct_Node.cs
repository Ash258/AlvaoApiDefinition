using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Statuses of the software profile on the products installed on the computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwProfileProduct_Node.html"/>
[Table("dbo.vSwProfileProduct_Node")]
public class vSwProfileProduct_Node {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwProfileProduct_Node.html#Alvao_API_Common_Model_Database_vSwProfileProduct_Node_liNodeId"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwProfileProduct_Node.html#Alvao_API_Common_Model_Database_vSwProfileProduct_Node_liProductId"/>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwProfileProduct_Node.html#Alvao_API_Common_Model_Database_vSwProfileProduct_Node_liSwPresenceId"/>
    public virtual int? liSwPresenceId { get; set; }
}
