using Alvao.API.AM.Model.Print;

namespace Alvao.API.AM;

/// <summary>Facade class grouping object print methods.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectPrint.html"/>
public static class ObjectPrint {
    /// <summary>
    /// Assembles the HTML print report and returns also parsed information extracted from the XML preview.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectPrint.html#Alvao_API_AM_ObjectPrint_AssemblePrintReport_Alvao_API_AM_Model_Print_ObjectsPrintModel_System_Boolean_"/>
    /// <param name="printModel">Model containing template selection, objects and contextual data for the report.</param>
    /// <param name="addSignButton">If true, signature placeholders are replaced with a sign button; otherwise with plain dots.</param>
    /// <returns>Tuple where Item1 is the HTML string and Item2 is supplementary preview info parsed from XML.</returns>
    public static (string, PrintPreviewXmlInfo) AssemblePrintReport(ObjectsPrintModel printModel, bool addSignButton) { throw new NotImplementedException(); }
    /// <summary>Generates a PDF byte array from raw HTML without persisting any document.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectPrint.html#Alvao_API_AM_ObjectPrint_GeneratePdf_System_String_Alvao_API_AM_Model_Print_PrintPageSettings_"/>
    /// <param name="html">HTML content to render into PDF.</param>
    /// <param name="pageSettings">Print page settings.</param>
    /// <returns>Byte array containing the rendered PDF file.</returns>
    public static byte[] GeneratePdf(string html, PrintPageSettings pageSettings) { throw new NotImplementedException(); }
    /// <summary>Generates a new document number based on the specified sequence identifier.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectPrint.html#Alvao_API_AM_ObjectPrint_GetNewDocumentNumber_System_Int32_"/>
    /// <param name="sequenceId">The identifier for the sequence from which to generate the document number. Must be a valid sequence ID.</param>
    /// <returns>A string representing the newly generated document number.</returns>
    public static string GetNewDocumentNumber(int sequenceId) { throw new NotImplementedException(); }
    /// <summary>Converts the provided HTML content into a PDF document.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectPrint.html#Alvao_API_AM_ObjectPrint_HtmlToPdfConverter_Alvao_API_AM_Model_Print_GeneratePdfModel_"/>
    /// <param name="model">An instance of GeneratePdfModel containing the HTML content and related settings for the PDF generation.</param>
    /// <returns>A byte array representing the generated PDF document.</returns>
    public static byte[] HtmlToPdfConverter(GeneratePdfModel model) { throw new NotImplementedException(); }
    /// <summary>Separate labels from preview HTML and for each object saves them into the DB</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.ObjectPrint.html#Alvao_API_AM_ObjectPrint_SaveAssetLabelsHtmlToDb_Alvao_API_AM_Model_Print_GeneratePdfModel_System_Int32_"/>
    /// <param name="model">PDF model containing information for the asset labels.</param>
    /// <param name="personId">ID of the person who saves the labels.</param>
    [Obsolete]
    public static void SaveAssetLabelsHtmlToDb(GeneratePdfModel model, int personId) { throw new NotImplementedException(); }
}
