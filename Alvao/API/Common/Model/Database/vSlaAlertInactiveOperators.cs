using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Individual SLA notifications for inactivity of the main solvers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators.htm"/>
[TableAttribute("dbo.vSlaAlertInactiveOperators")]
public class vSlaAlertInactiveOperators
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_fSummarySendHour.htm"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_liHdTicketId.htm"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_liSectionId.htm"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_liSlaAlertRuleId.htm"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_liSlaId.htm"/>
    public virtual int liSlaId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators__ctor.htm"/>
    public vSlaAlertInactiveOperators() { }
}
