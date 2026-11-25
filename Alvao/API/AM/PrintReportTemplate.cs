namespace Alvao.API.AM;

/// <summary>Facade class grouping print report template methods.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.PrintReportTemplate.html"/>
public static class PrintReportTemplate {
    /// <summary>Get print report template type ID from file stream.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.PrintReportTemplate.html#Alvao_API_AM_PrintReportTemplate_GetPrintReportTemplateTypeId_System_String_System_Boolean_System_Boolean_"/>
    /// <param name="data">String data of the file</param>
    /// <param name="isHtm">Is file html</param>
    /// <param name="isRep">Is file rep</param>
    /// <returns>Print report template type ID (PrintReportTemplate.PrintReportTemplateTypeId)</returns>
    public static int? GetPrintReportTemplateTypeId(string data, bool isHtm, bool isRep) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.PrintReportTemplate.html#Alvao_API_AM_PrintReportTemplate_GetPrintReportTemplateTypeIdFromHtml_System_String_"/>
    public static int? GetPrintReportTemplateTypeIdFromHtml(string data) { throw new NotImplementedException(); }
}
