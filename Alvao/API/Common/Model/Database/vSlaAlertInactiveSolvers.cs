using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA notifications for solver inactivity.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolvers.html"/>
[Table("dbo.vSlaAlertInactiveSolvers")]
public class vSlaAlertInactiveSolvers {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolvers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolvers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolvers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_liSectionId"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolvers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_liSlaAlertRuleId"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolvers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolvers_liSlaId"/>
    public virtual int liSlaId { get; set; }
}
