using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Types of links between licenses in the AM
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicHistRelationType.htm"/>
[TableAttribute("dbo.LicHistRelationType")]
public class LicHistRelationType
{
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
    /// <summary>Link behavior. If system or custom one. A foreign key on LicHistRelationTypeBehavior.</summary>
    public virtual int LicHistRelationTypeBehaviorId { get; set; }
    /// <summary>If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany.</summary>
    public virtual bool OneToMany { get; set; }

    public LicHistRelationType() { }
}
