using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rule for sending notifications for unresolved issues or an upcoming deadline.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html"/>
[Table("dbo.tSlaAlertRule")]
public class tSlaAlertRule {
    /// <summary>Number of hours until the expiry of the internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_FirstReactionExpireHours"/>
    public virtual double? FirstReactionExpireHours { get; set; }
    /// <summary>Number of hours until the expiry of the internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_InternalTargetExpireHours"/>
    public virtual double? InternalTargetExpireHours { get; set; }
    /// <summary>If the value is 1, an alert is sent by e-mail.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_SendByEmail"/>
    public virtual bool SendByEmail { get; set; }
    /// <summary>Alert severity (TicketAlertSeverity.id).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_TicketAlertSeverityId"/>
    public virtual int TicketAlertSeverityId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_dSummaryLastSent"/>
    public virtual DateTime? dSummaryLastSent { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_fDeadlineExpireHours"/>
    public virtual double? fDeadlineExpireHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_fInactiveHours"/>
    public virtual double? fInactiveHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_fRepeatEveryHours"/>
    public virtual double? fRepeatEveryHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_id"/>
    [Key]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_liInactiveRoleStringId"/>
    public virtual int? liInactiveRoleStringId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_liSlaId"/>
    public virtual int liSlaId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_liToRoleStringId"/>
    public virtual int? liToRoleStringId { get; set; }
}
