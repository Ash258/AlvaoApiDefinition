using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of links between objects in the AM.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html"/>
[Table("dbo.NodeRelationType")]
public class NodeRelationType {
    /// <summary>1 = health of the final object is influenced by the health of the starting object. 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_AffectsNodeHealth"/>
    public virtual bool AffectsNodeHealth { get; set; }
    /// <summary>Start of link (name).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_BeginName"/>
    public virtual string BeginName { get; set; }
    /// <summary>if creating circular tasks is permitted. 1 = Yes, 0 = No.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_Cyclic"/>
    public virtual bool Cyclic { get; set; }
    /// <summary>If the link is directional or non-directional. 1 = directional, 0 = non-directional.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_Directional"/>
    public virtual bool Directional { get; set; }
    /// <summary>End of link (name).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_EndName"/>
    public virtual string EndName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_LineColor"/>
    public virtual string LineColor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_LineStyle"/>
    public virtual string LineStyle { get; set; }
    /// <summary>Link behavior. System or custom. Foreign key to NodeRelationTypeBehavior.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_NodeRelationTypeBehaviorId"/>
    public virtual int NodeRelationTypeBehaviorId { get; set; }
    /// <summary>If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_OneToMany"/>
    public virtual bool OneToMany { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationType.html#Alvao_API_Common_Model_Database_NodeRelationType_id"/>
    [Key]
    public virtual int id { get; set; }
}
