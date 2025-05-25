using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA notifications for approver inactivity.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveApprovers.html"/>
[Table("dbo.vSlaAlertInactiveApprovers")]
public class vSlaAlertInactiveApprovers {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveApprovers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveApprovers_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveApprovers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveApprovers_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveApprovers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveApprovers_liSectionId"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveApprovers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveApprovers_liSlaAlertRuleId"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveApprovers.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveApprovers_liSlaId"/>
    public virtual int liSlaId { get; set; }
}
