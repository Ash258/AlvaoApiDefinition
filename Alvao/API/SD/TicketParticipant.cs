using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <summary>Facade class grouping ticket participant methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketParticipant.html"/>
public static class TicketParticipant {
    /// <summary>Add ticket participants to the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketParticipant.html#Alvao_API_SD_TicketParticipant_Add_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="ticketId">Request ID(tHdTicket.iHdTicketId).</param>
    /// <param name="idsToAdd">Collection of person IDs (tPerson.iPersonId).</param>
    /// <exception cref="ArgumentException">Throws when ticketId does not exist.</exception>
    /// <exception cref="UnauthorizedAccessException">Throws when current person is not requester, ticket participant, member of section team or system user.</exception>
    public static void Add(int ticketId, IEnumerable<int> idsToAdd) { throw new System.NotImplementedException(); }
    /// <summary>Get collection of ticket participants on the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketParticipant.html#Alvao_API_SD_TicketParticipant_Get_System_Int32_System_Boolean_"/>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId).</param>
    /// <param name="ignoreRequester">Ignore ticket participant that is also requester.</param>
    /// <exception cref="ArgumentException">Throws when ticketId does not exist.</exception>
    /// <returns>Collection of users that are ticket participants on the ticket.</returns>
    public static IEnumerable<tPerson> Get(int ticketId, bool ignoreRequester = false) { throw new System.NotImplementedException(); }
    /// <summary>Remove ticket participants from the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketParticipant.html#Alvao_API_SD_TicketParticipant_Remove_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="ticketId">Ticket ID(tHdTicket.iHdTicketId).</param>
    /// <param name="idsToRemove">Collection of person IDs (tPerson.iPersonId).</param>
    /// <exception cref="ArgumentException">Throws when ticketId does not exist.</exception>
    /// <exception cref="UnauthorizedAccessException">Throws when current person is not requester, ticket participant, member of section team or system user.</exception>
    public static void Remove(int ticketId, IEnumerable<int> idsToRemove) { throw new System.NotImplementedException(); }
}
