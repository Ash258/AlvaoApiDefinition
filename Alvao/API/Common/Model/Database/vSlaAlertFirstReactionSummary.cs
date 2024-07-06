using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Summary SLA notifications for the ticket first responses.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary.htm"/>
[TableAttribute("dbo.vSlaAlertFirstReactionSummary")]
public class vSlaAlertFirstReactionSummary
{
    public virtual int iHdTicketId { get; set; }
    public virtual int? iPersonLocaleId { get; set; }
    public virtual int iSlaAlertRuleId { get; set; }
    public virtual int? liToPersonId { get; set; }
    public virtual DateTime? NextActionDeadline { get; set; }
    public virtual string sHdSectionEmail { get; set; }
    public virtual string sHdTicket { get; set; }
    public virtual string sHdTicketUserEmail { get; set; }
    public virtual string sPerson { get; set; }
    public virtual string sPersonEmail { get; set; }
    public virtual string sPortalURL { get; set; }
    public virtual string sSolver { get; set; }
    public virtual string sTag { get; set; }

    public vSlaAlertFirstReactionSummary() { }
}
