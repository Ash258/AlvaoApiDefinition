using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Users with the permission to read software licenses belonging to the organization.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicRight_Read.htm"/>
[TableAttribute("dbo.vLicRight_Read")]
public class vLicRight_Read
{
    /// <summary>Organization (tblNode.intNodeId) to whose software licenses the permissions apply.</summary>
    public virtual int? NodeId { get; set; }
    /// <summary>Authorized user (tPerson.iPersonId)</summary>
    public virtual int? PersonId { get; set; }

    public vLicRight_Read() { }
}
