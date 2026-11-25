using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of links between objects in the AM.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html"/>
[Table("dbo.NodeRelationType")]
public class NodeRelationType {
    /// <summary>
    /// 1 = health of the final object is influenced by the health of the starting object. 0 = otherwise.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_AffectsNodeHealth"/>
    /// <remarks>Column <c>AffectsNodeHealth</c>: bit, not null.</remarks>
    public virtual bool AffectsNodeHealth { get; set; }
    /// <summary>Start of link (name).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_BeginName"/>
    /// <remarks>Column <c>BeginName</c>: nvarchar(255), not null.</remarks>
    public virtual string BeginName { get; set; }
    /// <summary>if creating circular tasks is permitted. 1 = Yes, 0 = No.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_Cyclic"/>
    /// <remarks>Column <c>Cyclic</c>: bit, not null.</remarks>
    public virtual bool Cyclic { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_DeterminesParametersOfCybersecurity"/>
    /// <remarks>Column <c>DeterminesParametersOfCybersecurity</c>: bit, not null.</remarks>
    public virtual bool DeterminesParametersOfCybersecurity { get; set; }
    /// <summary>If the link is directional or non-directional. 1 = directional, 0 = non-directional.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_Directional"/>
    /// <remarks>Column <c>Directional</c>: bit, not null.</remarks>
    public virtual bool Directional { get; set; }
    /// <summary>End of link (name).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_EndName"/>
    /// <remarks>Column <c>EndName</c>: nvarchar(255), not null.</remarks>
    public virtual string EndName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_LineColor"/>
    /// <remarks>Column <c>LineColor</c>: varchar, not null.</remarks>
    public virtual string LineColor { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_LineStyle"/>
    /// <remarks>Column <c>LineStyle</c>: varchar, not null.</remarks>
    public virtual string LineStyle { get; set; }
    /// <summary>Link behavior. System or custom. Foreign key to NodeRelationTypeBehavior.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_NodeRelationTypeBehaviorId"/>
    /// <remarks>
    /// Column <c>NodeRelationTypeBehaviorId</c>: int, not null. References <see cref="NodeRelationTypeBehavior"/>.
    /// </remarks>
    public virtual int NodeRelationTypeBehaviorId { get; set; }
    /// <summary>If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_OneToMany"/>
    /// <remarks>Column <c>OneToMany</c>: bit, not null.</remarks>
    public virtual bool OneToMany { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
