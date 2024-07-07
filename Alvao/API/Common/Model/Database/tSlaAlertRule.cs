using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rule for sending notifications for unresolved issues or an upcoming deadline.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSlaAlertRule.htm"/>
[TableAttribute("dbo.tSlaAlertRule")]
public class tSlaAlertRule
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_dSummaryLastSent.htm"/>
    public virtual DateTime? dSummaryLastSent { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_fDeadlineExpireHours.htm"/>
    public virtual double? fDeadlineExpireHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_fInactiveHours.htm"/>
    public virtual double? fInactiveHours { get; set; }
    /// <summary>Number of hours until the expiry of the internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_FirstReactionExpireHours.htm"/>
    public virtual double? FirstReactionExpireHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_fRepeatEveryHours.htm"/>
    public virtual double? fRepeatEveryHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_fSummarySendHour.htm"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Number of hours until the expiry of the internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_InternalTargetExpireHours.htm"/>
    public virtual double? InternalTargetExpireHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_liInactiveRoleStringId.htm"/>
    public virtual int? liInactiveRoleStringId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_liSlaId.htm"/>
    public virtual int liSlaId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_liToRoleStringId.htm"/>
    public virtual int? liToRoleStringId { get; set; }
    /// <summary>If the value is 1, an alert is sent by e-mail.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_SendByEmail.htm"/>
    public virtual bool SendByEmail { get; set; }
    /// <summary>Alert severity (TicketAlertSeverity.id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlertRule_TicketAlertSeverityId.htm"/>
    public virtual int TicketAlertSeverityId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSlaAlertRule__ctor.htm"/>
    public tSlaAlertRule() { }
}
