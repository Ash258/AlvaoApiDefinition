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
    [KeyAttribute]
    public virtual int iRolePersonId { get; set; }
    /// <summary>ID of the group from which the membership is promoted. NULL if the user has direct group membership.</summary>
    public virtual int? liRolePersonIncludedRoleId { get; set; }
    /// <summary>Link to user within group.</summary>
    public virtual int liRolePersonPersonId { get; set; }
    /// <summary>Link to group.</summary>
    public virtual int liRolePersonRoleId { get; set; }

    public tRolePerson() { }
}
