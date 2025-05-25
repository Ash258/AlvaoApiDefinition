using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket participant for the ticket</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRequestParticipant.html"/>
[Table("dbo.TicketRequestParticipant")]
public class TicketRequestParticipant {
    /// <summary>User ID of the ticket participant (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRequestParticipant.html#Alvao_API_Common_Model_Database_TicketRequestParticipant_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRequestParticipant.html#Alvao_API_Common_Model_Database_TicketRequestParticipant_TicketId"/>
    [ExplicitKey]
    public virtual int TicketId { get; set; }
}
