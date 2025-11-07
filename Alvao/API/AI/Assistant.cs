using Alvao.API.AI.Model;

namespace Alvao.API.AI;

/// <summary>Facade for Service Desk AI Assistant methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html"/>
public static class Assistant {
    /// <summary>Get instance of client for sending requests to Azure OpenAI.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetAIClient"/>
    /// <returns>Instance of a client for sending requests to Azure OpenAI.</returns>
    public static AIClient GetAIClient() { throw new NotImplementedException(); }
    /// <summary>Get model with AI Assistant data of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetModel_System_Int32_"/>
    /// <param name="ticketId">Id of the ticket.</param>
    /// <returns>Object containing AI Assistant data of the ticket.</returns>
    public static AssistantTicketTabModel GetModel(int ticketId) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSettings"/>
    public static AssistantSettings GetSettings() { throw new NotImplementedException(); }
    /// <summary>Get similar knowledge articles for the given text.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarKnowledgeArticles_System_String_System_Int32_System_Int32_"/>
    /// <param name="text">Input text for semantich search in articles</param>
    /// <param name="personId">Person ID used for access to articles. (0 - search in all articles)</param>
    /// <param name="count">Maximum count of similar articles to return</param>
    /// <returns>Collection of found articles that are similar to input text.</returns>
    public static List<KnowledgeTile> GetSimilarKnowledgeArticles(string text, int personId = 0, int count = 5) { throw new NotImplementedException(); }
    /// <summary>Tests if daily usage quota has not been exceeded.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_IsDailyLimitExceeded"/>
    /// <returns>True if enabled and within daily quota; otherwise false.</returns>
    public static bool IsDailyLimitExceeded() { throw new NotImplementedException(); }
    /// <summary>Update vector data of articles.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateArticles_System_Collections_Generic_IEnumerable_System_Int32__System_DateTime_"/>
    /// <param name="articleIds">List of article identificators.</param>
    /// <param name="endTime">End time to finish processing of articles.</param>
    /// <returns>Identificator of the last processed article.</returns>
    public static int UpdateArticles(IEnumerable<int> articleIds, DateTime endTime) { throw new NotImplementedException(); }
    /// <summary>Update centroid vectors for service from the vectors of tickets  in the service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateServiceVectors_System_Int32_"/>
    /// <param name="serviceId">Id of the service with tickets.</param>
    public static void UpdateServiceVectors(int serviceId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the ticket on the change of act.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketOnActChange_System_Int32_"/>
    /// <param name="actId">Act identificator.</param>
    public static void UpdateTicketOnActChange(int actId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the ticket on the change of ticket properties.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketOnChange_System_Int32_System_Collections_Generic_IEnumerable_System_String__"/>
    /// <param name="ticketId">Id of the ticket.</param>
    /// <param name="properties">Names of changed properties.</param>
    public static void UpdateTicketOnChange(int ticketId, IEnumerable<string> properties) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the tickets.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTickets_System_Collections_Generic_IEnumerable_System_Int32__System_DateTime_"/>
    /// <param name="ticketIds">List of ticket identificators.</param>
    /// <param name="endTime">End time to finish processing of tickets.</param>
    /// <returns>Identificator of the last processed ticket.</returns>
    public static int UpdateTickets(IEnumerable<int> ticketIds, DateTime endTime) { throw new NotImplementedException(); }
    /// <summary>Update part of AI Assistant data of the tickets that are influenced by change in object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketsOnObjectChange_System_Int32_System_Int32_"/>
    /// <param name="objectId">ID of changed object.</param>
    /// <param name="propertKindId">ID of changed property kind.</param>
    public static void UpdateTicketsOnObjectChange(int objectId, int propertKindId) { throw new NotImplementedException(); }
}
