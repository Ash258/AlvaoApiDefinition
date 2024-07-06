using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Summary SLA notifications for the expiration of the ticket deadline.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary.htm"/>
[TableAttribute("dbo.vSlaAlertDeadlineSummary")]
public class vSlaAlertDeadlineSummary
{
    public virtual DateTime? dHdTicketDeadline { get; set; }
    public virtual int iHdTicketId { get; set; }
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

    public vSlaAlertDeadlineSummary() { }
}
