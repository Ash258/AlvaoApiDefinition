using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Individual SLA alerts for the expiration of tickets internal target date.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertInternalTarget.htm"/>
[TableAttribute("dbo.vSlaAlertInternalTarget")]
public class vSlaAlertInternalTarget
{
    public virtual double? fSummarySendHour { get; set; }
    public virtual string InternalTarget { get; set; }
    public virtual DateTime? InternalTargetDeadline { get; set; }
    public virtual int iSlaAlertRuleId { get; set; }
    public virtual int liHdTicketId { get; set; }
    public virtual int liSectionId { get; set; }
    public virtual int liSlaId { get; set; }

    public vSlaAlertInternalTarget() { }
}
