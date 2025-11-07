using Alvao.API.Common;

namespace Alvao.API.AI;

/// <summary>Facade for DocumentIntelligence methods. ALVAO connection to Azure.AI.DocumentIntelligence service.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.DocumentIntelligence.html"/>
public static class DocumentIntelligence {
    /// <summary>Tests if the Document Intelligence service is enabled and daily usage quota has not been exceeded.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.DocumentIntelligence.html#Alvao_API_AI_DocumentIntelligence_CanBeUsed"/>
    /// <returns>True if enabled and within daily quota; otherwise false.</returns>
    public static bool CanBeUsed() { throw new NotImplementedException(); }
    /// <summary>Processes a document file using Azure Document Intelligence service and returns analysis results.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.DocumentIntelligence.html#Alvao_API_AI_DocumentIntelligence_ProcessAsync_System_BinaryData_System_Threading_CancellationToken_"/>
    /// <param name="fileToProcess">The binary content of the document to be processed.</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation.</param>
    /// <returns>An AnalyzedDocument containing the structured data extracted from the document.</returns>
    public static Task<AnalyzedDocument> ProcessAsync(BinaryData fileToProcess, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Tests if the Document Intelligence service is set up correctly and functioning properly.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.DocumentIntelligence.html#Alvao_API_AI_DocumentIntelligence_TestAsync_System_Threading_CancellationToken_"/>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation.</param>
    /// <returns>A boolean value indicating whether the service is available and properly configured (true) or not (false).</returns>
    public static Task<bool> TestAsync(CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
}
