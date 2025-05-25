using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Inheritance between objects</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeColumnInheritance.html"/>
[Table("dbo.NodeColumnInheritance")]
public class NodeColumnInheritance {
    /// <summary>ID of parent object (tblNode.intNodeId); NULL = this object property is inheritable.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeColumnInheritance.html#Alvao_API_Common_Model_Database_NodeColumnInheritance_InheritedFromNodeId"/>
    public virtual int? InheritedFromNodeId { get; set; }
    /// <summary>ID of object property (tblKind.intKindId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeColumnInheritance.html#Alvao_API_Common_Model_Database_NodeColumnInheritance_KindId"/>
    public virtual int KindId { get; set; }
    /// <summary>ID of object (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeColumnInheritance.html#Alvao_API_Common_Model_Database_NodeColumnInheritance_NodeId"/>
    [ExplicitKey]
    public virtual int NodeId { get; set; }
}
