using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket log records for notification sent for an unresolved issue or upcoming deadline.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html"/>
[Table("dbo.tSlaAlert")]
public class tSlaAlert {
    /// <summary>The expiration deadline of first response.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_FirstReactionDeadline"/>
    public virtual DateTime? FirstReactionDeadline { get; set; }
    /// <summary>Internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_InternalTargetDeadline"/>
    public virtual DateTime? InternalTargetDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_dHdTicketDeadline"/>
    public virtual DateTime? dHdTicketDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_dSent"/>
    public virtual DateTime dSent { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_id"/>
    [Key]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_liSlaAlertRuleId"/>
    public virtual int? liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_sError"/>
    public virtual string sError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaAlert.html#Alvao_API_Common_Model_Database_tSlaAlert_sTo"/>
    public virtual string sTo { get; set; }
}
