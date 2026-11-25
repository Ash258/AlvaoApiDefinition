using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Groups' membership in groups.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRoleRole.html"/>
[Table("dbo.tRoleRole")]
public class tRoleRole {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRoleRole.html#Alvao_API_Common_Model_Database_tRoleRole_iRoleRoleId"/>
    /// <remarks>Column <c>iRoleRoleId</c>: int, not null.</remarks>
    [Key]
    public virtual int iRoleRoleId { get; set; }
    /// <summary>Link to owned group.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRoleRole.html#Alvao_API_Common_Model_Database_tRoleRole_liRoleRoleMemberRoleId"/>
    /// <remarks>Column <c>liRoleRoleMemberRoleId</c>: int, not null. References <see cref="tRole"/>.</remarks>
    public virtual int liRoleRoleMemberRoleId { get; set; }
    /// <summary>Link to group owners.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRoleRole.html#Alvao_API_Common_Model_Database_tRoleRole_liRoleRoleRoleId"/>
    /// <remarks>Column <c>liRoleRoleRoleId</c>: int, not null. References <see cref="tRole"/>.</remarks>
    public virtual int liRoleRoleRoleId { get; set; }
}
