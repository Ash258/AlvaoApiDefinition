using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Permissions of persons and groups to software licenses of organizations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicRight.htm"/>
[TableAttribute("dbo.LicRight")]
public class LicRight
{
    /// <summary>Permission to modify</summary>
    public virtual byte? CanModify { get; set; }
    /// <summary>Permission to read</summary>
    public virtual byte? CanRead { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Organization (tblNode.intNodeId) to whose software licenses the permissions apply.</summary>
    public virtual int? NodeId { get; set; }
    /// <summary>Authorized user (tPerson.iPersonId)</summary>
    public virtual int? PersonId { get; set; }
    /// <summary>Authorized group of users (tRole.iRoleId)</summary>
    public virtual int? RoleId { get; set; }

    public LicRight() { }
}
