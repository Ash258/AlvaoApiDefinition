using Alvao.API.Common;
using Azure;

namespace Alvao.API.AI.Service;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Service.IDocumentIntelligenceClientService.html"/>
public interface IDocumentIntelligenceClientService {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Service.IDocumentIntelligenceClientService.html#Alvao_API_AI_Service_IDocumentIntelligenceClientService_AnalyzeDocumentAsync_System_String_System_String_System_String_System_BinaryData_System_Threading_CancellationToken_"/>
    Task<Operation<AnalyzeResult>> AnalyzeDocumentAsync(string endpoint, string apiKey, string modelId, BinaryData file, CancellationToken cancellationToken = default);
}
