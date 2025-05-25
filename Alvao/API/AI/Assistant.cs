using Alvao.API.AI.Model;

namespace Alvao.API.AI;

/// <summary>Facade for Service Desk AI Assistant methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html"/>
public static class Assistant {
    /// <summary>Get model with AI Assistant data of the ticket.</summary>
    /// <param name="ticketId">Id of the ticket.</param>
    /// <returns>Object containing AI Assistant data of the ticket.</returns>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetModel_System_Int32_"/>
    public static AssistantTicketTabModel GetModel(int ticketId) { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSettings"/>
    public static AssistantSettings GetSettings() { throw new System.NotImplementedException(); }

    /// <summary>Update vector data of articles.</summary>
    /// <param name="articleIds">List of article identificators.</param>
    /// <param name="endTime">End time to finish processing of articles.</param>
    /// <returns>Identificator of the last processed article.</returns>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateArticles_System_Collections_Generic_IEnumerable_System_Int32__System_DateTime_"/>
    public static int UpdateArticles(IEnumerable<int> articleIds, DateTime endTime) { throw new System.NotImplementedException(); }

    /// <summary>Update centroid vectors for service from the vectors of tickets in the service.</summary>
    /// <param name="serviceId">Id of the service with tickets.</param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateServiceVectors_System_Int32_"/>
    public static void UpdateServiceVectors(int serviceId) { throw new System.NotImplementedException(); }

    /// <summary>Update AI Assistant data of the ticket on the change of act.</summary>
    /// <param name="actId">Act identificator.</param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketOnActChange_System_Int32_"/>
    public static void UpdateTicketOnActChange(int actId) { throw new System.NotImplementedException(); }

    /// <summary>Update AI Assistant data of the ticket on the change of ticket properties.</summary>
    /// <param name="ticketId">Id of the ticket.</param>
    /// <param name="properties">Names of changed properties.</param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketOnChange_System_Int32_System_Collections_Generic_IEnumerable_System_String__"/>
    public static void UpdateTicketOnChange(int ticketId, IEnumerable<string> properties) { throw new System.NotImplementedException(); }

    /// <summary>Update AI Assistant data of the tickets.</summary>
    /// <param name="ticketIds">List of ticket identificators.</param>
    /// <param name="endTime">End time to finish processing of tickets.</param>
    /// <returns>Identificator of the last processed ticket.</returns>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTickets_System_Collections_Generic_IEnumerable_System_Int32__System_DateTime_"/>
    public static int UpdateTickets(IEnumerable<int> ticketIds, DateTime endTime) { throw new System.NotImplementedException(); }

    /// <summary>Update part of AI Assistant data of the tickets that are influenced by change in object.</summary>
    /// <param name="objectId">ID of changed object.</param>
    /// <param name="propertKindId">ID of changed property kind.</param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketsOnObjectChange_System_Int32_System_Int32_"/>
    public static void UpdateTicketsOnObjectChange(int objectId, int propertKindId) { throw new System.NotImplementedException(); }

}
