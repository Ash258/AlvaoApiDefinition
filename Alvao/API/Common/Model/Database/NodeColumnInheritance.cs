using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Inheritance between objects</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeColumnInheritance.html"/>
[Table("dbo.NodeColumnInheritance")]
public class NodeColumnInheritance {
    /// <summary>ID of parent object (tblNode.intNodeId); NULL = this object property is inheritable.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeColumnInheritance.html#Alvao_API_Common_Model_Database_NodeColumnInheritance_InheritedFromNodeId"/>
    /// <remarks>Column <c>InheritedFromNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? InheritedFromNodeId { get; set; }
    /// <summary>ID of object property (tblKind.intKindId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeColumnInheritance.html#Alvao_API_Common_Model_Database_NodeColumnInheritance_KindId"/>
    /// <remarks>Column <c>KindId</c>: int, not null. References <see cref="tblKind"/>.</remarks>
    [ExplicitKey]
    public virtual int KindId { get; set; }
    /// <summary>ID of object (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeColumnInheritance.html#Alvao_API_Common_Model_Database_NodeColumnInheritance_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    [ExplicitKey]
    public virtual int NodeId { get; set; }
}
