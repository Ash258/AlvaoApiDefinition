using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Allowed transitions among ticket statuses, see dbo.TicketState.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRelation.html"/>
[Table("dbo.TicketStateRelation")]
public class TicketStateRelation {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRelation.html#Alvao_API_Common_Model_Database_TicketStateRelation_BeginTicketStateId"/>
    /// <remarks>Column <c>BeginTicketStateId</c>: int, not null. References <see cref="TicketState"/>.</remarks>
    public virtual int BeginTicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRelation.html#Alvao_API_Common_Model_Database_TicketStateRelation_EndTicketStateId"/>
    /// <remarks>Column <c>EndTicketStateId</c>: int, not null. References <see cref="TicketState"/>.</remarks>
    public virtual int EndTicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRelation.html#Alvao_API_Common_Model_Database_TicketStateRelation_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
