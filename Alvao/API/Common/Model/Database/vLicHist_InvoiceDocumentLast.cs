using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Invoice attached to the license.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHist_InvoiceDocumentLast.html"/>
[Table("dbo.vLicHist_InvoiceDocumentLast")]
public class vLicHist_InvoiceDocumentLast {
    /// <summary>Document (tblDocument.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHist_InvoiceDocumentLast.html#Alvao_API_Common_Model_Database_vLicHist_InvoiceDocumentLast_AMDocumentId"/>
    public virtual int? AMDocumentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHist_InvoiceDocumentLast.html#Alvao_API_Common_Model_Database_vLicHist_InvoiceDocumentLast_LicHistId"/>
    public virtual int? LicHistId { get; set; }
}
