using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Persons' membership in groups.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html"/>
[Table("dbo.tRolePerson")]
public class tRolePerson {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html#Alvao_API_Common_Model_Database_tRolePerson_iRolePersonId"/>
    /// <remarks>Column <c>iRolePersonId</c>: int, not null.</remarks>
    [Key]
    public virtual int iRolePersonId { get; set; }
    /// <summary>
    /// ID of the group from which the membership is promoted. NULL if the user has direct group membership.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html#Alvao_API_Common_Model_Database_tRolePerson_liRolePersonIncludedRoleId"/>
    /// <remarks>Column <c>liRolePersonIncludedRoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? liRolePersonIncludedRoleId { get; set; }
    /// <summary>Link to user within group.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html#Alvao_API_Common_Model_Database_tRolePerson_liRolePersonPersonId"/>
    /// <remarks>Column <c>liRolePersonPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int liRolePersonPersonId { get; set; }
    /// <summary>Link to group.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html#Alvao_API_Common_Model_Database_tRolePerson_liRolePersonRoleId"/>
    /// <remarks>Column <c>liRolePersonRoleId</c>: int, not null. References <see cref="tRole"/>.</remarks>
    public virtual int liRolePersonRoleId { get; set; }
}
