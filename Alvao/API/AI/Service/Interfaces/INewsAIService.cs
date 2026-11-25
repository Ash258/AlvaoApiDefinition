using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.INewsAIService.html"/>
public interface INewsAIService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.INewsAIService.html#Alvao_API_AI_Service_Interfaces_INewsAIService_GetSimilarNewsAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    Task<IEnumerable<SimilarEntityResult>> GetSimilarNewsAsync(string text, int personId, int count, double? similarityPercent = null, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.INewsAIService.html#Alvao_API_AI_Service_Interfaces_INewsAIService_OnNewsChanged_System_Int32_"/>
    void OnNewsChanged(int newsId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.INewsAIService.html#Alvao_API_AI_Service_Interfaces_INewsAIService_OnNewsChangedJobAsync_System_Int32_System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task OnNewsChangedJobAsync(int newsId, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.INewsAIService.html#Alvao_API_AI_Service_Interfaces_INewsAIService_ReindexChunksAsync_System_Int32_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    Task<bool> ReindexChunksAsync(int prevModelId, int newModelId, int maxCount, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.INewsAIService.html#Alvao_API_AI_Service_Interfaces_INewsAIService_UpdateNewsAsync_System_Collections_Generic_IEnumerable_System_Int32__System_DateTime_System_Threading_CancellationToken_"/>
    Task<bool> UpdateNewsAsync(IEnumerable<int> newsIds, DateTime endTime, CancellationToken cancellationToken = default);
}
