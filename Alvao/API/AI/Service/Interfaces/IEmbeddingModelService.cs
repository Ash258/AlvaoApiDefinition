using Alvao.API.AI.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html"/>
public interface IEmbeddingModelService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_AbortReindexingAsync_System_Threading_CancellationToken_"/>
    Task AbortReindexingAsync(CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_FinishReindexingAsync_System_Threading_CancellationToken_"/>
    Task FinishReindexingAsync(CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_GetAbortedModelId"/>
    int GetAbortedModelId();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_GetActiveModelAsync_System_Threading_CancellationToken_"/>
    Task<EmbeddingModel> GetActiveModelAsync(CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_GetAllModelsAsync_System_Threading_CancellationToken_"/>
    Task<IEnumerable<EmbeddingModel>> GetAllModelsAsync(CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_GetDeploymentName"/>
    string GetDeploymentName();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_GetEmbeddingCountsAsync_System_Int32_System_Threading_CancellationToken_"/>
    Task<EmbeddingCounts> GetEmbeddingCountsAsync(int modelId, CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_GetEnabledModels_System_Boolean_"/>
    IList<EmbeddingModel> GetEnabledModels(bool useCache = false);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_OnReindexingAbortedJob_System_Int32_"/>
    void OnReindexingAbortedJob(int modelId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_RemoveStoppedReindexingAsync_System_Int32_System_Threading_CancellationToken_"/>
    Task<bool> RemoveStoppedReindexingAsync(int modelId, CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_SaveModelAsync_System_String_System_String_System_Threading_CancellationToken_"/>
    Task SaveModelAsync(string modelName, string deploymentName, CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IEmbeddingModelService.html#Alvao_API_AI_Service_Interfaces_IEmbeddingModelService_SetStatusAsync_System_Int32_Alvao_API_AI_Model_EmbeddingModelStatus_System_Threading_CancellationToken_"/>
    Task SetStatusAsync(int id, EmbeddingModelStatus status, CancellationToken cancellationToken);
}
