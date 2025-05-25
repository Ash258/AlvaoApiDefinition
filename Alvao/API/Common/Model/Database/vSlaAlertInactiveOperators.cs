using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA notifications for inactivity of the main solvers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveOperators.html"/>
[Table("dbo.vSlaAlertInactiveOperators")]
public class vSlaAlertInactiveOperators {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveOperators.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveOperators.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveOperators.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_liSectionId"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveOperators.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_liSlaAlertRuleId"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveOperators.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveOperators_liSlaId"/>
    public virtual int liSlaId { get; set; }
}
