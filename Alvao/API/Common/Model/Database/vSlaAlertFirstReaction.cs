using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Individual SLA notifications for the ticket first responses.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertFirstReaction.htm"/>
[TableAttribute("dbo.vSlaAlertFirstReaction")]
public class vSlaAlertFirstReaction
{
    public virtual double? fSummarySendHour { get; set; }
    public virtual int iSlaAlertRuleId { get; set; }
    public virtual int liHdTicketId { get; set; }
    public virtual int liSectionId { get; set; }
    public virtual int liSlaId { get; set; }
    public virtual DateTime? NextActionDeadline { get; set; }

    public vSlaAlertFirstReaction() { }
}
