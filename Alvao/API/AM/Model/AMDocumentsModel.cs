using Alvao.API.Common.Model;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html"/>
public class AMDocumentsModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_AttachmentsList"/>
    public IEnumerable<AttachmentModel> AttachmentsList { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_DocumentFolder"/>
    public int DocumentFolder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_ExternalIdNumber"/>
    public string ExternalIdNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_IdNumber"/>
    public string IdNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Ids"/>
    public string Ids { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_IsIdNumberGenerated"/>
    public bool IsIdNumberGenerated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_IsInvoiceOrDeliveryNote"/>
    public bool IsInvoiceOrDeliveryNote { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Issued"/>
    public DateTime? Issued { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Licenses"/>
    public IEnumerable<int> Licenses { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Links"/>
    public IEnumerable<LinksModel> Links { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Notes"/>
    public string Notes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Objects"/>
    public IEnumerable<int> Objects { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_SignedOnPaper"/>
    public bool SignedOnPaper { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Type"/>
    public int Type { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AMDocumentsModel.html#Alvao_API_AM_Model_AMDocumentsModel_Vendor"/>
    public int? Vendor { get; set; }
}
