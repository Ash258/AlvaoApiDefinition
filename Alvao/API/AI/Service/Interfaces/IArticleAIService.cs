using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IArticleAIService.html"/>
public interface IArticleAIService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IArticleAIService.html#Alvao_API_AI_Service_Interfaces_IArticleAIService_GetSimilarArticleChunksAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    Task<IEnumerable<SimilarChunkResult>> GetSimilarArticleChunksAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IArticleAIService.html#Alvao_API_AI_Service_Interfaces_IArticleAIService_GetSimilarArticlesAsync_System_String_System_Int32_System_Int32_System_Nullable_System_Double__System_Threading_CancellationToken_"/>
    Task<IEnumerable<SimilarEntityResult>> GetSimilarArticlesAsync(string text, int personId = 0, int count = 5, double? similarityPercent = null, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IArticleAIService.html#Alvao_API_AI_Service_Interfaces_IArticleAIService_GetSimilarKnowledgeArticles_System_String_System_Int32_System_Int32_"/>
    List<KnowledgeTile> GetSimilarKnowledgeArticles(string text, int personId = 0, int count = 5);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IArticleAIService.html#Alvao_API_AI_Service_Interfaces_IArticleAIService_OnArticleChange_System_Int32_"/>
    void OnArticleChange(int articleId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IArticleAIService.html#Alvao_API_AI_Service_Interfaces_IArticleAIService_OnArticleChangeJobAsync_System_Int32_System_Threading_CancellationToken_"/>
    [JobExpiration(1)]
    Task OnArticleChangeJobAsync(int articleId, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IArticleAIService.html#Alvao_API_AI_Service_Interfaces_IArticleAIService_ReindexChunksAsync_System_Int32_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    Task<bool> ReindexChunksAsync(int prevModelId, int newModelId, int maxCount, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IArticleAIService.html#Alvao_API_AI_Service_Interfaces_IArticleAIService_UpdateArticlesAsync_System_Collections_Generic_IEnumerable_System_Int32__System_DateTime_System_Threading_CancellationToken_"/>
    Task<int> UpdateArticlesAsync(IEnumerable<int> articleIds, DateTime endTime, CancellationToken cancellationToken = default);
}
