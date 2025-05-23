using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permissions of persons and groups to software licenses of organizations.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicRight.htm"/>
[TableAttribute("dbo.LicRight")]
public class LicRight {
    /// <summary>Permission to modify</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicRight_CanModify.htm"/>
    public virtual byte? CanModify { get; set; }
    /// <summary>Permission to read</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicRight_CanRead.htm"/>
    public virtual byte? CanRead { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicRight_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Organization (tblNode.intNodeId) to whose software licenses the permissions apply.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicRight_NodeId.htm"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Authorized user (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicRight_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <summary>Authorized group of users (tRole.iRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicRight_RoleId.htm"/>
    public virtual int? RoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LicRight__ctor.htm"/>
    public LicRight() { }
}
