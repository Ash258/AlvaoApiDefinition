using Alvao.API.Common;
using Azure;

namespace Alvao.API.AI.Service.Implementation;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Service.Implementation.DocumentIntelligenceClientService.html"/>
public class DocumentIntelligenceClientService : ServiceBase, IDocumentIntelligenceClientService {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Service.Implementation.DocumentIntelligenceClientService.html#Alvao_API_AI_Service_Implementation_DocumentIntelligenceClientService_AnalyzeDocumentAsync_System_String_System_String_System_String_System_BinaryData_System_Threading_CancellationToken_"/>
    public Task<Operation<AnalyzeResult>> AnalyzeDocumentAsync(string endpoint, string apiKey, string modelId, BinaryData file, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
}
