using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Summary SLA alerts for the expiration of tickets internal target date.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertInternalTargetSummary.htm"/>
[TableAttribute("dbo.vSlaAlertInternalTargetSummary")]
public class vSlaAlertInternalTargetSummary
{
    public virtual int iHdTicketId { get; set; }
    public virtual string InternalTarget { get; set; }
    public virtual DateTime? InternalTargetDeadline { get; set; }
    public virtual int? iPersonLocaleId { get; set; }
    public virtual int iSlaAlertRuleId { get; set; }
    public virtual int? liToPersonId { get; set; }
    public virtual string sHdSectionEmail { get; set; }
    public virtual string sHdTicket { get; set; }
    public virtual string sHdTicketUserEmail { get; set; }
    public virtual string sPerson { get; set; }
    public virtual string sPersonEmail { get; set; }
    public virtual string sPortalURL { get; set; }
    public virtual string sSolver { get; set; }
    public virtual string sTag { get; set; }

    public vSlaAlertInternalTargetSummary() { }
}
