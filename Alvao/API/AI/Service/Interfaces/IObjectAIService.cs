using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IObjectAIService.html"/>
public interface IObjectAIService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IObjectAIService.html#Alvao_API_AI_Service_Interfaces_IObjectAIService_GetSimilarObjectsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    Task<IEnumerable<SimilarEntityResult>> GetSimilarObjectsAsync(string text, int personId, int count, double? similarityPercent = null, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IObjectAIService.html#Alvao_API_AI_Service_Interfaces_IObjectAIService_GetSimilarPersonAssetsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    Task<IEnumerable<SimilarEntityResult>> GetSimilarPersonAssetsAsync(string text, int personId, int count, double? similarityPercent = null, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IObjectAIService.html#Alvao_API_AI_Service_Interfaces_IObjectAIService_OnObjectPropertyModified_System_Int32_"/>
    void OnObjectPropertyModified(int objectId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IObjectAIService.html#Alvao_API_AI_Service_Interfaces_IObjectAIService_OnObjectPropertyModifiedJobAsync_System_Int32_System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task OnObjectPropertyModifiedJobAsync(int objectId, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IObjectAIService.html#Alvao_API_AI_Service_Interfaces_IObjectAIService_ReindexEmbeddingsAsync_System_Int32_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    Task<bool> ReindexEmbeddingsAsync(int prevModelId, int newModelId, int maxCount, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IObjectAIService.html#Alvao_API_AI_Service_Interfaces_IObjectAIService_UpdateObjectsVectorsAsync_System_Collections_Generic_IEnumerable_System_Int32__System_Threading_CancellationToken_"/>
    Task<bool> UpdateObjectsVectorsAsync(IEnumerable<int> objectIds, CancellationToken cancellationToken = default);
}
