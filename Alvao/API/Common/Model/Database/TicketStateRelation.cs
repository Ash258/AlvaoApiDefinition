using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Allowed transitions among ticket statuses, see dbo.TicketState.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRelation.html"/>
[Table("dbo.TicketStateRelation")]
public class TicketStateRelation {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRelation.html#Alvao_API_Common_Model_Database_TicketStateRelation_BeginTicketStateId"/>
    public virtual int BeginTicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRelation.html#Alvao_API_Common_Model_Database_TicketStateRelation_EndTicketStateId"/>
    public virtual int EndTicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRelation.html#Alvao_API_Common_Model_Database_TicketStateRelation_id"/>
    [Key]
    public virtual int id { get; set; }
}
