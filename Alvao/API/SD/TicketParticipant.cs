using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <summary>Facade&nbsp;class&nbsp;grouping&nbsp;ticket&nbsp;participant methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_TicketParticipant.htm"/>
public static class TicketParticipant
{

    /// <summary>Add ticket participants to the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketParticipant_Add.htm"/>
    ///
    /// <param name="ticketId">Request ID(tHdTicket.iHdTicketId).</param>
    /// <param name="idsToAdd">Collection of person IDs (tPerson.iPersonId).</param>
    public static void Add(
        int ticketId,
        IEnumerable<int> idsToAdd
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get collection of ticket participants on the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketParticipant_Get.htm"/>
    ///
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId).</param>
    /// <param name="ignoreRequester">Ignore ticket participant that is also requester.</param>
    public static IEnumerable<tPerson> Get(
        int ticketId,
        bool ignoreRequester = false
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Remove ticket participants from the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketParticipant_Remove.htm"/>
    ///
    /// <param name="ticketId">Ticket ID(tHdTicket.iHdTicketId).</param>
    /// <param name="idsToRemove">Collection of person IDs (tPerson.iPersonId).</param>
    public static void Remove(
        int ticketId,
        IEnumerable<int> idsToRemove
    )
    { throw new System.NotImplementedException(); }
}
