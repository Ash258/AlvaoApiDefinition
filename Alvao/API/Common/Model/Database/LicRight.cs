using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permissions of persons and groups to software licenses of organizations.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html"/>
[Table("dbo.LicRight")]
public class LicRight {
    /// <summary>Permission to modify</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_CanModify"/>
    public virtual byte? CanModify { get; set; }
    /// <summary>Permission to read</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_CanRead"/>
    public virtual byte? CanRead { get; set; }
    /// <summary>Organization (tblNode.intNodeId) to whose software licenses the permissions apply.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_NodeId"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Authorized user (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>Authorized group of users (tRole.iRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicRight.html#Alvao_API_Common_Model_Database_LicRight_id"/>
    [Key]
    public virtual int id { get; set; }
}
