using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Users with the permission to change software licenses belonging to the organization.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicRight_Modify.htm"/>
[TableAttribute("dbo.vLicRight_Modify")]
public class vLicRight_Modify
{
    /// <summary>Organization (tblNode.intNodeId) to whose software licenses the permissions apply.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicRight_Modify_NodeId.htm"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Authorized user (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicRight_Modify_PersonId.htm"/>
    public virtual int? PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vLicRight_Modify__ctor.htm"/>
    public vLicRight_Modify() { }
}
