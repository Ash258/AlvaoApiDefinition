using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permissions of persons and groups to software licenses of organizations.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html"/>
[Table("dbo.LicRight")]
public class LicRight {
    /// <summary>Permission to modify</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_CanModify"/>
    /// <remarks>Column <c>CanModify</c>: tinyint, null.</remarks>
    public virtual byte? CanModify { get; set; }
    /// <summary>Permission to read</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_CanRead"/>
    /// <remarks>Column <c>CanRead</c>: tinyint, null.</remarks>
    public virtual byte? CanRead { get; set; }
    /// <summary>Organization (tblNode.intNodeId) to whose software licenses the permissions apply.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? NodeId { get; set; }
    /// <summary>Authorized user (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? PersonId { get; set; }
    /// <summary>Authorized group of users (tRole.iRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? RoleId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
