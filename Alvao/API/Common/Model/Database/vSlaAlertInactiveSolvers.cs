using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Individual SLA notifications for solver inactivity.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers.htm"/>
[TableAttribute("dbo.vSlaAlertInactiveSolvers")]
public class vSlaAlertInactiveSolvers
{
    public virtual double? fSummarySendHour { get; set; }
    public virtual int liHdTicketId { get; set; }
    public virtual int liSectionId { get; set; }
    public virtual int liSlaAlertRuleId { get; set; }
    public virtual int liSlaId { get; set; }

    public vSlaAlertInactiveSolvers() { }
}
