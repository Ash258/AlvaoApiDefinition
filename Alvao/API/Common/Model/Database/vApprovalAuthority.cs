using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Current approvers of tickets that are currently in the process of being approved.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vApprovalAuthority.htm"/>
[TableAttribute("dbo.vApprovalAuthority")]
public class vApprovalAuthority
{
    public virtual int? liApprovalAuthorityHdTicketId { get; set; }
    public virtual int? liApprovalAuthorityPersonId { get; set; }

    public vApprovalAuthority() { }
}
