using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Summary SLA alerts for requester inactivity.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary.htm"/>
[TableAttribute("dbo.vSlaAlertInactiveRequestersSummary")]
public class vSlaAlertInactiveRequestersSummary
{
    public virtual double? fSummarySendHour { get; set; }
    public virtual int iHdTicketId { get; set; }
    public virtual int? iPersonLocaleId { get; set; }
    public virtual int liSlaAlertRuleId { get; set; }
    public virtual int? liToPersonId { get; set; }
    public virtual string sHdSectionEmail { get; set; }
    public virtual string sHdTicket { get; set; }
    public virtual string sHdTicketUserEmail { get; set; }
    public virtual string sPerson { get; set; }
    public virtual string sPersonEmail { get; set; }
    public virtual string sPortalURL { get; set; }
    public virtual string sSolver { get; set; }
    public virtual string sTag { get; set; }

    public vSlaAlertInactiveRequestersSummary() { }
}
