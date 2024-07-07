using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Persons' membership in groups.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tRolePerson.htm"/>
[TableAttribute("dbo.tRolePerson")]
public class tRolePerson
{
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRolePerson_iRolePersonId.htm"/>
    [KeyAttribute]
    public virtual int iRolePersonId { get; set; }
    /// <summary>ID of the group from which the membership is promoted. NULL if the user has direct group membership.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRolePerson_liRolePersonIncludedRoleId.htm"/>
    public virtual int? liRolePersonIncludedRoleId { get; set; }
    /// <summary>Link to user within group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRolePerson_liRolePersonPersonId.htm"/>
    public virtual int liRolePersonPersonId { get; set; }
    /// <summary>Link to group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRolePerson_liRolePersonRoleId.htm"/>
    public virtual int liRolePersonRoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tRolePerson__ctor.htm"/>
    public tRolePerson() { }
}
