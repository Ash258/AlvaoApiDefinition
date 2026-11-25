using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rule for sending notifications for unresolved issues or an upcoming deadline.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html"/>
[Table("dbo.tSlaAlertRule")]
public class tSlaAlertRule {
    /// <summary>Number of hours until the expiry of the internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_FirstReactionExpireHours"/>
    /// <remarks>Column <c>FirstReactionExpireHours</c>: float, null.</remarks>
    public virtual double? FirstReactionExpireHours { get; set; }
    /// <summary>Number of hours until the expiry of the internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_InternalTargetExpireHours"/>
    /// <remarks>Column <c>InternalTargetExpireHours</c>: float, null.</remarks>
    public virtual double? InternalTargetExpireHours { get; set; }
    /// <summary>If the value is 1, an alert is sent by email.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_SendByEmail"/>
    /// <remarks>Column <c>SendByEmail</c>: bit, not null.</remarks>
    public virtual bool SendByEmail { get; set; }
    /// <summary>Alert severity (TicketAlertSeverity.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_TicketAlertSeverityId"/>
    /// <remarks>
    /// Column <c>TicketAlertSeverityId</c>: int, not null. References <see cref="TicketAlertSeverity"/>.
    /// </remarks>
    public virtual int TicketAlertSeverityId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_dSummaryLastSent"/>
    /// <remarks>Column <c>dSummaryLastSent</c>: datetime, null.</remarks>
    public virtual DateTime? dSummaryLastSent { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_fDeadlineExpireHours"/>
    /// <remarks>Column <c>fDeadlineExpireHours</c>: float, null.</remarks>
    public virtual double? fDeadlineExpireHours { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_fInactiveHours"/>
    /// <remarks>Column <c>fInactiveHours</c>: float, null.</remarks>
    public virtual double? fInactiveHours { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_fRepeatEveryHours"/>
    /// <remarks>Column <c>fRepeatEveryHours</c>: float, null.</remarks>
    public virtual double? fRepeatEveryHours { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_fSummarySendHour"/>
    /// <remarks>Column <c>fSummarySendHour</c>: float, null.</remarks>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_liInactiveRoleStringId"/>
    /// <remarks>Column <c>liInactiveRoleStringId</c>: int, null. References <see cref="tString"/>.</remarks>
    public virtual int? liInactiveRoleStringId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_liSlaId"/>
    /// <remarks>Column <c>liSlaId</c>: int, not null. References <see cref="tSla"/>.</remarks>
    public virtual int liSlaId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlertRule.html#Alvao_API_Common_Model_Database_tSlaAlertRule_liToRoleStringId"/>
    /// <remarks>Column <c>liToRoleStringId</c>: int, null. References <see cref="tString"/>.</remarks>
    public virtual int? liToRoleStringId { get; set; }
}
