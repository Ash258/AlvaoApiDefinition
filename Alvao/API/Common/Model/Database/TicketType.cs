using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Processes. Among others, the process defines possible ticket statuses, solving process, custom ticket items, etc.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketType.html"/>
[Table("dbo.TicketType")]
public class TicketType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketType.html#Alvao_API_Common_Model_Database_TicketType_BackResolveDeadlineHours"/>
    public virtual double? BackResolveDeadlineHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketType.html#Alvao_API_Common_Model_Database_TicketType_CustomField1"/>
    public virtual int? CustomField1 { get; set; }
    /// <summary>Description of the process</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketType.html#Alvao_API_Common_Model_Database_TicketType_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Process type ID (TicketTypeBehavior.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketType.html#Alvao_API_Common_Model_Database_TicketType_TicketTypeBehaviorId"/>
    public virtual int TicketTypeBehaviorId { get; set; }
    /// <summary>ID of the effect of tickets with this process on the health of objects in the given tickets (TicketTypeNodeHealthImpact.id). 1=no effect, 2=incident, 3=change.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketType.html#Alvao_API_Common_Model_Database_TicketType_TicketTypeNodeHealthImpactId"/>
    public virtual int TicketTypeNodeHealthImpactId { get; set; }
    /// <summary>Process name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketType.html#Alvao_API_Common_Model_Database_TicketType__TicketType"/>
    public virtual string _TicketType { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketType.html#Alvao_API_Common_Model_Database_TicketType_id"/>
    [Key]
    public virtual int id { get; set; }
}
