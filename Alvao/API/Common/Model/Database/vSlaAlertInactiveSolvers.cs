using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA notifications for solver inactivity.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers.htm"/>
[TableAttribute("dbo.vSlaAlertInactiveSolvers")]
public class vSlaAlertInactiveSolvers
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_fSummarySendHour.htm"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_liHdTicketId.htm"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_liSectionId.htm"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_liSlaAlertRuleId.htm"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_liSlaId.htm"/>
    public virtual int liSlaId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers__ctor.htm"/>
    public vSlaAlertInactiveSolvers() { }
}
