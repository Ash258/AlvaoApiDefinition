using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Persons' membership in groups.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html"/>
[Table("dbo.tRolePerson")]
public class tRolePerson {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html#Alvao_API_Common_Model_Database_tRolePerson_iRolePersonId"/>
    [Key]
    public virtual int iRolePersonId { get; set; }
    /// <summary>ID of the group from which the membership is promoted. NULL if the user has direct group membership.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html#Alvao_API_Common_Model_Database_tRolePerson_liRolePersonIncludedRoleId"/>
    public virtual int? liRolePersonIncludedRoleId { get; set; }
    /// <summary>Link to user within group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html#Alvao_API_Common_Model_Database_tRolePerson_liRolePersonPersonId"/>
    public virtual int liRolePersonPersonId { get; set; }
    /// <summary>Link to group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRolePerson.html#Alvao_API_Common_Model_Database_tRolePerson_liRolePersonRoleId"/>
    public virtual int liRolePersonRoleId { get; set; }
}
