using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Groups' membership in groups.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRoleRole.html"/>
[Table("dbo.tRoleRole")]
public class tRoleRole {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRoleRole.html#Alvao_API_Common_Model_Database_tRoleRole_iRoleRoleId"/>
    [Key]
    public virtual int iRoleRoleId { get; set; }
    /// <summary>Link to owned group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRoleRole.html#Alvao_API_Common_Model_Database_tRoleRole_liRoleRoleMemberRoleId"/>
    public virtual int liRoleRoleMemberRoleId { get; set; }
    /// <summary>Link to group owners.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRoleRole.html#Alvao_API_Common_Model_Database_tRoleRole_liRoleRoleRoleId"/>
    public virtual int liRoleRoleRoleId { get; set; }
}
