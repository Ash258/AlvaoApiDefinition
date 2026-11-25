using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket log records for notification sent for an unresolved issue or upcoming deadline.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html"/>
[Table("dbo.tSlaAlert")]
public class tSlaAlert {
    /// <summary>The expiration deadline of first response.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_FirstReactionDeadline"/>
    /// <remarks>Column <c>FirstReactionDeadline</c>: datetime, null.</remarks>
    public virtual DateTime? FirstReactionDeadline { get; set; }
    /// <summary>Internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_InternalTargetDeadline"/>
    /// <remarks>Column <c>InternalTargetDeadline</c>: datetime, null.</remarks>
    public virtual DateTime? InternalTargetDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_dHdTicketDeadline"/>
    /// <remarks>Column <c>dHdTicketDeadline</c>: datetime, null.</remarks>
    public virtual DateTime? dHdTicketDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_dSent"/>
    /// <remarks>Column <c>dSent</c>: datetime, not null.</remarks>
    public virtual DateTime dSent { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_liHdTicketId"/>
    /// <remarks>Column <c>liHdTicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_liSlaAlertRuleId"/>
    /// <remarks>Column <c>liSlaAlertRuleId</c>: int, null. References <see cref="tSlaAlertRule"/>.</remarks>
    public virtual int? liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_sError"/>
    /// <remarks>Column <c>sError</c>: nvarchar(max), null.</remarks>
    public virtual string sError { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_sTo"/>
    /// <remarks>Column <c>sTo</c>: nvarchar(1024), not null.</remarks>
    public virtual string sTo { get; set; }
}
