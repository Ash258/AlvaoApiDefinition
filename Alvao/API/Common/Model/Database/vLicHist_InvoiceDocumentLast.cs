using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Invoice attached to the license.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicHist_InvoiceDocumentLast.htm"/>
[TableAttribute("dbo.vLicHist_InvoiceDocumentLast")]
public class vLicHist_InvoiceDocumentLast
{
    /// <summary>Document (tblDocument.id)</summary>
    public virtual int? AMDocumentId { get; set; }
    public virtual int? LicHistId { get; set; }

    public vLicHist_InvoiceDocumentLast() { }
}
