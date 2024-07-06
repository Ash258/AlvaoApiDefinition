using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Individual SLA notifications for the expiration of the ticket deadline.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertDeadline.htm"/>
[TableAttribute("dbo.vSlaAlertDeadline")]
public class vSlaAlertDeadline
{
    public virtual DateTime? dHdTicketDeadline { get; set; }
    public virtual double? fSummarySendHour { get; set; }
    public virtual int iSlaAlertRuleId { get; set; }
    public virtual int liHdTicketId { get; set; }
    public virtual int liSectionId { get; set; }
    public virtual int liSlaId { get; set; }

    public vSlaAlertDeadline() { }
}
