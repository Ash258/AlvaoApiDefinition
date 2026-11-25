using Alvao.API.AI.Infrastructure;
using Alvao.API.AI.Infrastructure.Interfaces;
using Alvao.API.AI.Model;
using Alvao.API.Common.Model;

namespace Alvao.API.AI;

/// <summary>Facade for Service Desk AI Assistant methods.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html"/>
public static class Assistant {
    /// <summary>Get instance of client for sending requests to Azure OpenAI.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetAIClient"/>
    /// <returns>Instance of a client for sending requests to Azure OpenAI.</returns>
    public static AIClient GetAIClient() { throw new NotImplementedException(); }
    /// <summary>
    /// Get embedding for the given text. Token usage for the statistics will be saved with provided groupName.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetEmbedding_System_String_System_String_System_String_System_Int32_"/>
    /// <param name="text">Input text to create the embedding.</param>
    /// <param name="vectorName">Vector name used for usage statistics.</param>
    /// <param name="entityName">Entity name used for usage statistics.</param>
    /// <param name="entityId">Entity ID used for logging.</param>
    /// <returns>Calculated vector and success result of the operation.</returns>
    public static (float[] vector, bool success) GetEmbedding(string text, string vectorName = null, string entityName = null, int entityId = 0) { throw new NotImplementedException(); }
    /// <summary>
    /// Retrieves vector representations for the specified entities of a given type from database or Azure AI Search.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetEntityVectors_Alvao_API_Common_Model_AzureAISearchEntityType_System_Collections_Generic_IEnumerable_System_Int32__System_Threading_CancellationToken_"/>
    /// <param name="entityType">The type of entity for which to retrieve vectors. Determines the category of entities to be processed.</param>
    /// <param name="entityIds">A collection of entity identifiers for which vectors will be retrieved. Each identifier must correspond to a valid entity of the specified type.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a collection of entity vectors
    /// corresponding to the specified entity identifiers.
    /// </returns>
    public static Task<IEnumerable<EntityVector>> GetEntityVectors(AzureAISearchEntityType entityType, IEnumerable<int> entityIds, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>
    /// Get instance of the async Foundry (Azure.AI.OpenAI SDK based) client for sending requests to Azure OpenAI.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetFoundryAIClient"/>
    /// <returns>Instance of a client for sending requests to Azure OpenAI.</returns>
    public static IAIClient GetFoundryAIClient() { throw new NotImplementedException(); }
    /// <summary>Get model with AI Assistant data of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetModelAsync_System_Int32_"/>
    /// <param name="ticketId">Id of the ticket.</param>
    /// <returns>Object containing AI Assistant data of the ticket.</returns>
    public static Task<AssistantTicketTabModel> GetModelAsync(int ticketId) { throw new NotImplementedException(); }
    /// <summary>Retrieves the current configuration settings for the assistant.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSettings"/>
    /// <returns>An instance of AssistantSettings containing the latest assistant configuration values.</returns>
    public static AssistantSettings GetSettings() { throw new NotImplementedException(); }
    /// <summary>
    /// Get similar chunks of articles for the given text. Search is performed among all article chunks if personId is
    /// 0, otherwise only among chunks of articles available for the person.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarArticleChunksAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    /// <returns>Collection of found article chunks with similarity.</returns>
    public static Task<IEnumerable<SimilarChunkResult>> GetSimilarArticleChunksAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>
    /// Get similar articles for the given text. Search is performed among all articles if personId is 0, otherwise only
    /// among articles available for the person.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarArticlesAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    /// <returns>Collection of found article records with ID and similarity.</returns>
    public static Task<IEnumerable<SimilarEntityResult>> GetSimilarArticlesAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Get similar knowledge articles for the given text.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarKnowledgeArticles_System_String_System_Int32_System_Int32_"/>
    /// <param name="text">Input text for semantich search in articles</param>
    /// <param name="personId">Person ID used for access to articles. (0 - search in all articles)</param>
    /// <param name="count">Maximum count of similar articles to return</param>
    /// <returns>Collection of found articles that are similar to input text.</returns>
    [Obsolete("This method is deprecated. Please use GetSimilarArticlesAsync or GetSimilarArticleChunksAsync instead.")]
    public static List<KnowledgeTile> GetSimilarKnowledgeArticles(string text, int personId = 0, int count = 5) { throw new NotImplementedException(); }
    /// <summary>
    /// Get similar news for the given text. Search is performed among all news if personId is 0, otherwise only among
    /// news available for the person.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarNewsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    /// <returns>Collection of found news with ID and similarity.</returns>
    public static Task<IEnumerable<SimilarEntityResult>> GetSimilarNewsAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>
    /// Get similar objects for the given text. Search is performed among all objects if personId is 0, otherwise only
    /// among objects available for the person.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarObjectsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    /// <returns>Collection of found objects with ID and similarity.</returns>
    public static Task<IEnumerable<SimilarEntityResult>> GetSimilarObjectsAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>
    /// Retrieves a collection of assets that are similar to those associated with the specified person, based on the
    /// provided text input.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarPersonAssetsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    /// <returns>
    /// An enumerable collection of SimilarEntityResult objects representing assets similar to those of the specified
    /// person. The collection is empty if no similar assets are found.
    /// </returns>
    public static Task<IEnumerable<SimilarEntityResult>> GetSimilarPersonAssetsAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Get similar requester's tickets for the given text.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarRequestersTicketsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    /// <returns>Collection of found tickets with ID and similarity.</returns>
    public static Task<IEnumerable<SimilarEntityResult>> GetSimilarRequestersTicketsAsync(string text, int personId, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>
    /// Get similar services for the given text. Search is performed among all services if personId is 0, otherwise only
    /// among services available for the person.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarServicesAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    /// <returns>Collection of found services with ID and similarity.</returns>
    public static Task<IEnumerable<SimilarEntityResult>> GetSimilarServicesAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>
    /// Get similar tickets for the given text. Search is performed among all tickets if personId is 0, otherwise only
    /// among tickets available for the person.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetSimilarTicketsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    /// <returns>Collection of found tickets with ID and similarity.</returns>
    public static Task<IEnumerable<SimilarEntityResult>> GetSimilarTicketsAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>
    /// Retrieves a vector representation of the specified text based on the provided entity information and property
    /// name.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_GetVector_System_String_Alvao_API_AI_Model_EntityInfo_System_String_"/>
    /// <param name="text">The input text to generate the vector for.</param>
    /// <param name="entityInfo">The entity information used to contextualize the vector generation.</param>
    /// <param name="propertyName">The name of the property influencing the vector generation.</param>
    /// <returns>A string representing the generated vector.</returns>
    public static string GetVector(string text, EntityInfo entityInfo, string propertyName) { throw new NotImplementedException(); }
    /// <summary>Check whether the computation of article vector is enabled.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_IsArticleVectorEnabled"/>
    public static bool IsArticleVectorEnabled() { throw new NotImplementedException(); }
    /// <summary>Check whether Azure AI search is available.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_IsAzureSemanticSearchAvailable"/>
    public static bool IsAzureSemanticSearchAvailable() { throw new NotImplementedException(); }
    /// <summary>Check whether the computation of searching vector is enabled.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_IsComputionOfSearchingVectorEnabled"/>
    public static bool IsComputionOfSearchingVectorEnabled() { throw new NotImplementedException(); }
    /// <summary>Tests if daily embedding tokens usage quota has not been exceeded.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_IsDailyEmbeddingLimitExceeded"/>
    public static bool IsDailyEmbeddingLimitExceeded() { throw new NotImplementedException(); }
    /// <summary>Tests if daily usage quota has not been exceeded.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_IsDailyLimitExceeded"/>
    /// <returns>True if enabled and within daily quota; otherwise false.</returns>
    public static bool IsDailyLimitExceeded() { throw new NotImplementedException(); }
    /// <summary>Check whether the database supports vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_IsDbSemanticSearchAvailable"/>
    public static bool IsDbSemanticSearchAvailable() { throw new NotImplementedException(); }
    /// <summary>
    /// Check whether semantic search is available (either Azure AI Search or database vector semantic search).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_IsSemanticSearchAvailable"/>
    public static bool IsSemanticSearchAvailable() { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the ticket on the change of act.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_OnActChanged_System_Int32_"/>
    /// <param name="actId">Act identificator.</param>
    public static void OnActChanged(int actId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the ticket on the creating of act.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_OnActCreated_System_Int32_"/>
    /// <param name="actId">Act identificator.</param>
    public static void OnActCreated(int actId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the ticket on the removing of act.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_OnActRemoved_System_Int32_"/>
    /// <param name="actId">Act identificator.</param>
    public static void OnActRemoved(int actId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the article.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_OnArticleChange_System_Int32_"/>
    /// <param name="articleId">Id of changed article.</param>
    public static void OnArticleChange(int articleId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the news.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_OnNewsChanged_System_Int32_"/>
    /// <param name="newsId">Id of news.</param>
    public static void OnNewsChanged(int newsId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_OnObjectPropertyModified_System_Int32_"/>
    /// <param name="objectId">Id of changed object.</param>
    public static void OnObjectPropertyModified(int objectId) { throw new NotImplementedException(); }
    /// <summary>
    /// Update Description vector of the service on the change of service properties. Don't update mean vectors of the
    /// service.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_OnServiceChange_System_Int32_"/>
    /// <param name="serviceId">Id of the service.</param>
    public static void OnServiceChange(int serviceId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the ticket on the change of act.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketOnActChange_System_Int32_"/>
    /// <param name="actId">Act identificator.</param>
    public static void UpdateTicketOnActChange(int actId) { throw new NotImplementedException(); }
    /// <summary>Update AI Assistant data of the ticket on the change of ticket properties.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketOnChange_System_Int32_System_Collections_Generic_IEnumerable_System_String__"/>
    /// <param name="ticketId">Id of the ticket.</param>
    /// <param name="properties">Names of changed properties.</param>
    public static void UpdateTicketOnChange(int ticketId, IEnumerable<string> properties) { throw new NotImplementedException(); }
    /// <summary>Update part of AI Assistant data of the tickets that are influenced by change in object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Assistant.html#Alvao_API_AI_Assistant_UpdateTicketsOnObjectChange_System_Int32_System_Int32_"/>
    /// <param name="objectId">ID of changed object.</param>
    /// <param name="propertKindId">ID of changed property kind.</param>
    public static void UpdateTicketsOnObjectChange(int objectId, int propertKindId) { throw new NotImplementedException(); }
}
