using Alvao.API.AM.Model;
using Alvao.API.Common;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.InvoiceProcessor.html"/>
public static class InvoiceProcessor {
    /// <summary>Processes an analyzed document to extract am document information</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.InvoiceProcessor.html#Alvao_API_AM_InvoiceProcessor_LoadDocumentInfo_Azure_AI_DocumentIntelligence_AnalyzedDocument_"/>
    /// <param name="document">The analyzed document containing invoice data</param>
    /// <returns>Basic informations that are loaded from document</returns>
    public static AMDocumentsModel LoadDocumentInfo(AnalyzedDocument document) { throw new NotImplementedException(); }
    /// <summary>Processes an analyzed document to extract invoice information</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.InvoiceProcessor.html#Alvao_API_AM_InvoiceProcessor_ProcessFileAsync_Azure_AI_DocumentIntelligence_AnalyzedDocument_System_Threading_CancellationToken_"/>
    /// <param name="document">The analyzed document containing invoice data</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation</param>
    /// <returns>Collection of invoice processing results</returns>
    public static Task<IEnumerable<InvoiceTemplate>> ProcessFileAsync(AnalyzedDocument document, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
}
