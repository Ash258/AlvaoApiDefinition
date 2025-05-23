using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Invoice attached to the license.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicHist_InvoiceDocumentLast.htm"/>
[TableAttribute("dbo.vLicHist_InvoiceDocumentLast")]
public class vLicHist_InvoiceDocumentLast {
    /// <summary>Document (tblDocument.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHist_InvoiceDocumentLast_AMDocumentId.htm"/>
    public virtual int? AMDocumentId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHist_InvoiceDocumentLast_LicHistId.htm"/>
    public virtual int? LicHistId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vLicHist_InvoiceDocumentLast__ctor.htm"/>
    public vLicHist_InvoiceDocumentLast() { }
}
