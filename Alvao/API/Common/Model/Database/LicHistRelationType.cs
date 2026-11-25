using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of links between licenses in the AM</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationType.html"/>
[Table("dbo.LicHistRelationType")]
public class LicHistRelationType {
    /// <summary>Start of link (name).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationType.html#Alvao_API_Common_Model_Database_LicHistRelationType_BeginName"/>
    /// <remarks>Column <c>BeginName</c>: nvarchar(32), not null.</remarks>
    public virtual string BeginName { get; set; }
    /// <summary>if creating circular tasks is permitted. 1 = Yes, 0 = No.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationType.html#Alvao_API_Common_Model_Database_LicHistRelationType_Cyclic"/>
    /// <remarks>Column <c>Cyclic</c>: bit, not null.</remarks>
    public virtual bool Cyclic { get; set; }
    /// <summary>If the link is directional or non-directional. 1 = directional, 0 = non-directional.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationType.html#Alvao_API_Common_Model_Database_LicHistRelationType_Directional"/>
    /// <remarks>Column <c>Directional</c>: bit, not null.</remarks>
    public virtual bool Directional { get; set; }
    /// <summary>End of link (name).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationType.html#Alvao_API_Common_Model_Database_LicHistRelationType_EndName"/>
    /// <remarks>Column <c>EndName</c>: nvarchar(32), not null.</remarks>
    public virtual string EndName { get; set; }
    /// <summary>Link behavior. If system or custom one. A foreign key on LicHistRelationTypeBehavior.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationType.html#Alvao_API_Common_Model_Database_LicHistRelationType_LicHistRelationTypeBehaviorId"/>
    /// <remarks>
    /// Column <c>LicHistRelationTypeBehaviorId</c>: int, not null. References <see
    /// cref="LicHistRelationTypeBehavior"/>.
    /// </remarks>
    public virtual int LicHistRelationTypeBehaviorId { get; set; }
    /// <summary>If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationType.html#Alvao_API_Common_Model_Database_LicHistRelationType_OneToMany"/>
    /// <remarks>Column <c>OneToMany</c>: bit, not null.</remarks>
    public virtual bool OneToMany { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationType.html#Alvao_API_Common_Model_Database_LicHistRelationType_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
