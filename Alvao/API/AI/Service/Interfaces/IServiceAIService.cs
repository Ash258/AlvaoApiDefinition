using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IServiceAIService.html"/>
public interface IServiceAIService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IServiceAIService.html#Alvao_API_AI_Service_Interfaces_IServiceAIService_CalculateMeanVectorsAsync_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    Task CalculateMeanVectorsAsync(int serviceId, int modelId = 0, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IServiceAIService.html#Alvao_API_AI_Service_Interfaces_IServiceAIService_GetSimilarServicesAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    Task<IEnumerable<SimilarEntityResult>> GetSimilarServicesAsync(string text, int personId, int count, double? similarityPercent = null, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IServiceAIService.html#Alvao_API_AI_Service_Interfaces_IServiceAIService_OnServiceChanged_System_Int32_"/>
    void OnServiceChanged(int serviceId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IServiceAIService.html#Alvao_API_AI_Service_Interfaces_IServiceAIService_OnServiceChangedJobAsync_System_Int32_System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task OnServiceChangedJobAsync(int serviceId, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IServiceAIService.html#Alvao_API_AI_Service_Interfaces_IServiceAIService_RecalculateMeanVectorsAsync_System_Int32_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    Task<bool> RecalculateMeanVectorsAsync(int prevModelId, int newModelId, int maxCount, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IServiceAIService.html#Alvao_API_AI_Service_Interfaces_IServiceAIService_ReindexEmbeddingsAsync_System_Int32_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    Task<bool> ReindexEmbeddingsAsync(int prevModelId, int newModelId, int maxCount, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IServiceAIService.html#Alvao_API_AI_Service_Interfaces_IServiceAIService_UpdateDescriptionVectorsAsync_System_Collections_Generic_IEnumerable_System_Int32__System_Threading_CancellationToken_"/>
    Task UpdateDescriptionVectorsAsync(IEnumerable<int> serviceIds, CancellationToken cancellationToken = default);
}
