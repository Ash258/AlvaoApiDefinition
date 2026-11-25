using Alvao.API.AI.Model;
using Alvao.API.Common.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html"/>
public interface IVectorService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html#Alvao_API_AI_Service_Interfaces_IVectorService_GetEmbedding_System_String_System_String_System_String_System_Int32_"/>
    (float[] vector, bool success) GetEmbedding(string text, string vectorName = null, string entityName = null, int entityId = 0);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html#Alvao_API_AI_Service_Interfaces_IVectorService_GetEmbeddingAsync_System_String_System_String_System_String_System_Int32_System_Threading_CancellationToken_"/>
    Task<(float[] vector, bool success)> GetEmbeddingAsync(string text, string vectorName, string entityName, int entityId, CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html#Alvao_API_AI_Service_Interfaces_IVectorService_GetEmbeddings_System_String_System_String_System_String_System_Int32_System_Int32_"/>
    Dictionary<int, float[]> GetEmbeddings(string text, string vectorName = null, string entityType = null, int entityId = 0, int modelId = 0);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html#Alvao_API_AI_Service_Interfaces_IVectorService_GetEmbeddingsAsync_System_String_System_String_System_String_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    Task<Dictionary<int, float[]>> GetEmbeddingsAsync(string text, string vectorName, string entityType, int entityId, int modelId, CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html#Alvao_API_AI_Service_Interfaces_IVectorService_GetEntityVectors_Alvao_API_Common_Model_AzureAISearchEntityType_System_Collections_Generic_IEnumerable_System_Int32__System_Threading_CancellationToken_"/>
    Task<IEnumerable<EntityVector>> GetEntityVectors(AzureAISearchEntityType entityType, IEnumerable<int> entityIds, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html#Alvao_API_AI_Service_Interfaces_IVectorService_GetVector_System_String_Alvao_API_AI_Model_EntityInfo_System_String_"/>
    string GetVector(string text, EntityInfo entityInfo, string propertyName);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html#Alvao_API_AI_Service_Interfaces_IVectorService_InsertChunksAsync_Alvao_API_Common_Model_AzureAISearchEntityType_System_Int32_System_Collections_Generic_IEnumerable_System_String__System_Func_System_String_System_String__System_Int32_System_Threading_CancellationToken_"/>
    Task<bool> InsertChunksAsync(AzureAISearchEntityType entityType, int id, IEnumerable<string> texts, Func<string, string> formatText = null, int embeddingModelId = 0, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IVectorService.html#Alvao_API_AI_Service_Interfaces_IVectorService_UpdateVectorAsync_Alvao_API_Common_Model_AzureAISearchEntityType_System_Int32_System_Int32_System_String_System_Int32_System_Threading_CancellationToken_"/>
    Task<Dictionary<int, float[]>> UpdateVectorAsync(AzureAISearchEntityType entityType, int id, int serviceId, string text, int embeddingModelId = 0, CancellationToken cancellationToken = default);
}
