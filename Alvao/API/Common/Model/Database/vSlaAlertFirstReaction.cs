using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA notifications for the ticket first responses.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertFirstReaction.html"/>
[Table("dbo.vSlaAlertFirstReaction")]
public class vSlaAlertFirstReaction {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertFirstReaction.html#Alvao_API_Common_Model_Database_vSlaAlertFirstReaction_NextActionDeadline"/>
    public virtual DateTime? NextActionDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertFirstReaction.html#Alvao_API_Common_Model_Database_vSlaAlertFirstReaction_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertFirstReaction.html#Alvao_API_Common_Model_Database_vSlaAlertFirstReaction_iSlaAlertRuleId"/>
    public virtual int iSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertFirstReaction.html#Alvao_API_Common_Model_Database_vSlaAlertFirstReaction_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertFirstReaction.html#Alvao_API_Common_Model_Database_vSlaAlertFirstReaction_liSectionId"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertFirstReaction.html#Alvao_API_Common_Model_Database_vSlaAlertFirstReaction_liSlaId"/>
    public virtual int liSlaId { get; set; }
}
