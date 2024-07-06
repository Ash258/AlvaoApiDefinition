using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Types of links between objects in the AM.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NodeRelationType.htm"/>
[TableAttribute("dbo.NodeRelationType")]
public class NodeRelationType
{
    /// <summary>1 = health of the final object is influenced by the health of the starting object. 0 = otherwise.</summary>
    public virtual bool AffectsNodeHealth { get; set; }
    /// <summary>Start of link (name).</summary>
    public virtual string BeginName { get; set; }
    /// <summary>if creating circular tasks is permitted. 1 = Yes, 0 = No.</summary>
    public virtual bool Cyclic { get; set; }
    /// <summary>If the link is directional or non-directional. 1 = directional, 0 = non-directional.</summary>
    public virtual bool Directional { get; set; }
    /// <summary>End of link (name).</summary>
    public virtual string EndName { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual string LineColor { get; set; }
    public virtual string LineStyle { get; set; }
    /// <summary>Link behavior. System or custom. Foreign key to NodeRelationTypeBehavior.</summary>
    public virtual int NodeRelationTypeBehaviorId { get; set; }
    /// <summary>If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany.</summary>
    public virtual bool OneToMany { get; set; }

    public NodeRelationType() { }
}
