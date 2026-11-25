using Alvao.API.AI.Service.Interfaces;
using Alvao.API.Common;
using Azure;
using Azure.AI.DocumentIntelligence;

namespace Alvao.API.AI.Service;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.DocumentIntelligenceClientService.html"/>
public class DocumentIntelligenceClientService : ServiceBase, IDocumentIntelligenceClientService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.DocumentIntelligenceClientService.html#Alvao_API_AI_Service_DocumentIntelligenceClientService_AnalyzeDocumentAsync_System_String_System_String_System_String_System_BinaryData_System_Threading_CancellationToken_"/>
    public Task<Operation<AnalyzeResult>> AnalyzeDocumentAsync(string endpoint, string apiKey, string modelId, BinaryData file, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
}
