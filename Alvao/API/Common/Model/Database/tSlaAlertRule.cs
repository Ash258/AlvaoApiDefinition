using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rule for sending notifications for unresolved issues or an upcoming deadline.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSlaAlertRule.htm"/>
[TableAttribute("dbo.tSlaAlertRule")]
public class tSlaAlertRule
{
    public virtual DateTime? dSummaryLastSent { get; set; }
    public virtual double? fDeadlineExpireHours { get; set; }
    public virtual double? fInactiveHours { get; set; }
    /// <summary>Number of hours until the expiry of the internal target date.</summary>
    public virtual double? FirstReactionExpireHours { get; set; }
    public virtual double? fRepeatEveryHours { get; set; }
    public virtual double? fSummarySendHour { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Number of hours until the expiry of the internal target date.</summary>
    public virtual double? InternalTargetExpireHours { get; set; }
    public virtual int? liInactiveRoleStringId { get; set; }
    public virtual int liSlaId { get; set; }
    public virtual int? liToRoleStringId { get; set; }
    /// <summary>If the value is 1, an alert is sent by e-mail.</summary>
    public virtual bool SendByEmail { get; set; }
    /// <summary>Alert severity (TicketAlertSeverity.id).</summary>
    public virtual int TicketAlertSeverityId { get; set; }

    public tSlaAlertRule() { }
}
