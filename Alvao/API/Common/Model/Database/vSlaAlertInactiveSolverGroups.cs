using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA notifications for solver group inactivity.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolverGroups.html"/>
[Table("dbo.vSlaAlertInactiveSolverGroups")]
public class vSlaAlertInactiveSolverGroups {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolverGroups.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolverGroups_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolverGroups.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolverGroups_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolverGroups.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolverGroups_liSectionId"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolverGroups.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolverGroups_liSlaAlertRuleId"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveSolverGroups.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveSolverGroups_liSlaId"/>
    public virtual int liSlaId { get; set; }
}
