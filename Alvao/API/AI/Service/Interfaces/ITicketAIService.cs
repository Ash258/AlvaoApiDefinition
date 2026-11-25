using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html"/>
public interface ITicketAIService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_CalculateDescriptionVectorAsync_System_Collections_Generic_IEnumerable_System_Int32__System_DateTime_System_Threading_CancellationToken_"/>
    Task CalculateDescriptionVectorAsync(IEnumerable<int> ticketIds, DateTime endTime, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_GetSimilarRequestersTicketsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    Task<IEnumerable<SimilarEntityResult>> GetSimilarRequestersTicketsAsync(string text, int personId, int count, double? similarityPercent = null, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_GetSimilarTicketsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    Task<IEnumerable<SimilarEntityResult>> GetSimilarTicketsAsync(string text, int personId, int count, double? similarityPercent = null, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_OnActChanged_System_Int32_"/>
    void OnActChanged(int actId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_OnActChangedJobAsync_Alvao_API_AI_Model_TicketActAssistantDataModel_System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task OnActChangedJobAsync(TicketActAssistantDataModel dataModel, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_OnActCreated_System_Int32_"/>
    void OnActCreated(int actId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_OnActCreatedJobAsync_Alvao_API_AI_Model_TicketActAssistantDataModel_System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task OnActCreatedJobAsync(TicketActAssistantDataModel dataModel, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_OnActRemoved_System_Int32_"/>
    void OnActRemoved(int actId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_OnActRemovedJobAsync_Alvao_API_AI_Model_TicketActAssistantDataModel_System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task OnActRemovedJobAsync(TicketActAssistantDataModel dataModel, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_ReindexEmbeddingsAsync_System_Int32_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    Task<bool> ReindexEmbeddingsAsync(int prevModelId, int newModelId, int maxCount, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_UpdateTicketOnChange_System_Int32_System_Collections_Generic_IEnumerable_System_String__"/>
    void UpdateTicketOnChange(int ticketId, IEnumerable<string> properties);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_UpdateTicketOnChangeJobAsync_Alvao_API_AI_Model_TicketAssistantDataModel_System_Collections_Generic_List_System_String__System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task UpdateTicketOnChangeJobAsync(TicketAssistantDataModel dataModel, List<string> properties, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_UpdateTicketsAsync_System_Collections_Generic_IEnumerable_System_Int32__System_DateTime_Alvao_API_AI_Model_VectorType_System_Threading_CancellationToken_"/>
    Task<int> UpdateTicketsAsync(IEnumerable<int> ticketIds, DateTime endTime, VectorType vectorType, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_UpdateTicketsOnObjectChange_System_Int32_System_Int32_"/>
    void UpdateTicketsOnObjectChange(int objectId, int propertKindId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.ITicketAIService.html#Alvao_API_AI_Service_Interfaces_ITicketAIService_UpdateTicketsOnObjectChangeJobAsync_System_Int32_System_Int32_System_Collections_Generic_List_Alvao_API_AI_Model_TicketAssistantDataModel__System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task UpdateTicketsOnObjectChangeJobAsync(int objectId, int propertKindId, List<TicketAssistantDataModel> dataModels, CancellationToken cancellationToken = default);
}
