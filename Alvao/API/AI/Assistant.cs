using Alvao.API.AI.Model;

namespace Alvao.API.AI;

/// <summary>Facade for Service Desk AI Assistant methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_Assistant.htm"/>
public static class Assistant {

    /// <summary>Get model with AI Assistant data of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Assistant_GetModel.htm"/>
    ///
    /// <param name="ticketId">Id of the ticket.</param>
    public static AssistantTicketTabModel GetModel(
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Update vector data of articles.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Assistant_UpdateArticles.htm"/>
    ///
    /// <param name="articleIds">List of article identificators.</param>
    /// <param name="endTime">End time to finish processing of articles.</param>
    public static int UpdateArticles(
        IEnumerable<int> articleIds,
        DateTime endTime
    ) { throw new System.NotImplementedException(); }

    /// <summary>Update centroid vectors for service from the vectors of tickets in the service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Assistant_UpdateServiceVectors.htm"/>
    ///
    /// <param name="serviceId">Id of the service with tickets.</param>
    public static void UpdateServiceVectors(
        int serviceId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Update AI Assistant data of the ticket on the change of act.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Assistant_UpdateTicketOnActChange.htm"/>
    ///
    /// <param name="actId">Act identificator.</param>
    /// <param name="checkImportantAndRequester">Update data only if the act is marked as important or is a communication with the requester.</param>
    public static void UpdateTicketOnActChange(
        int actId,
        bool checkImportantAndRequester
    ) { throw new System.NotImplementedException(); }

    /// <summary>Update AI Assistant data of the new created ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Assistant_UpdateTicketOnCreated.htm"/>
    ///
    /// <param name="ticketId">Id of the ticket.</param>
    public static void UpdateTicketOnCreated(
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Update AI Assistant data of the ticket on the change of ticket properties.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Assistant_UpdateTicketOnChange.htm"/>
    ///
    /// <param name="ticketId">Id of the ticket.</param>
    /// <param name="properties">Names of changed properties.</param>
    public static void UpdateTicketOnChange(
        int ticketId,
        string properties
    ) { throw new System.NotImplementedException(); }

    /// <summary>Update AI Assistant data of the tickets.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Assistant_UpdateTickets.htm"/>
    ///
    /// <param name="ticketIds">List of ticket identificators.</param>
    /// <param name="endTime">End time to finish processing of tickets.</param>
    public static int UpdateTickets(
        IEnumerable<int> ticketIds,
        DateTime endTime
    ) { throw new System.NotImplementedException(); }

    /// <summary>Update part of AI Assistant data of the tickets that are influenced by change in objects.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Assistant_UpdateTicketsOnObjectChange.htm"/>
    ///
    /// <param name="ticketIds">List of ticket identificators.</param>
    /// <param name="endTime">End time to finish processing of tickets.</param>
    public static int UpdateTicketsOnObjectChange(
        IEnumerable<int> ticketIds,
        DateTime endTime
    ) { throw new System.NotImplementedException(); }
}
