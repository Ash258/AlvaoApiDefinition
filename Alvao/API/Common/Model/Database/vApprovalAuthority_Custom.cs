using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Current ticket approvers according to custom approval processes. The customer can define custom contents for///           this view.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vApprovalAuthority_Custom.htm"/>
[TableAttribute("dbo.vApprovalAuthority_Custom")]
public class vApprovalAuthority_Custom
{
    public virtual int? liHdTicketId { get; set; }
    public virtual int? liPersonId { get; set; }

    public vApprovalAuthority_Custom() { }
}
