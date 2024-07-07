using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Groups' membership in groups.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tRoleRole.htm"/>
[TableAttribute("dbo.tRoleRole")]
public class tRoleRole
{
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRoleRole_iRoleRoleId.htm"/>
    [KeyAttribute]
    public virtual int iRoleRoleId { get; set; }
    /// <summary>Link to owned group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRoleRole_liRoleRoleMemberRoleId.htm"/>
    public virtual int liRoleRoleMemberRoleId { get; set; }
    /// <summary>Link to group owners.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRoleRole_liRoleRoleRoleId.htm"/>
    public virtual int liRoleRoleRoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tRoleRole__ctor.htm"/>
    public tRoleRole() { }
}
