using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket participant for the ticket</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketRequestParticipant.htm"/>
[TableAttribute("dbo.TicketRequestParticipant")]
public class TicketRequestParticipant {
    /// <summary>User ID of the ticket participant (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRequestParticipant_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRequestParticipant_TicketId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int TicketId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketRequestParticipant__ctor.htm"/>
    public TicketRequestParticipant() { }
}
