using Azure;
using Azure.AI.DocumentIntelligence;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IDocumentIntelligenceClientService.html"/>
public interface IDocumentIntelligenceClientService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IDocumentIntelligenceClientService.html#Alvao_API_AI_Service_Interfaces_IDocumentIntelligenceClientService_AnalyzeDocumentAsync_System_String_System_String_System_String_System_BinaryData_System_Threading_CancellationToken_"/>
    Task<Operation<AnalyzeResult>> AnalyzeDocumentAsync(string endpoint, string apiKey, string modelId, BinaryData file, CancellationToken cancellationToken = default);
}
