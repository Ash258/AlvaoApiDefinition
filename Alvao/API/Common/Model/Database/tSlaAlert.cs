using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket log records for notification sent for an unresolved issue or upcoming deadline.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSlaAlert.htm"/>
[TableAttribute("dbo.tSlaAlert")]
public class tSlaAlert
{
    public virtual DateTime? dHdTicketDeadline { get; set; }
    public virtual DateTime dSent { get; set; }
    /// <summary>The expiration deadline of first response.</summary>
    public virtual DateTime? FirstReactionDeadline { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Internal target date.</summary>
    public virtual DateTime? InternalTargetDeadline { get; set; }
    public virtual int liHdTicketId { get; set; }
    public virtual int? liSlaAlertRuleId { get; set; }
    public virtual string sError { get; set; }
    public virtual string sTo { get; set; }

    public tSlaAlert() { }
}
