namespace Alvao.API.AM.Model.Print;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html"/>
public class GeneratePdfModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_CreatorId"/>
    public int CreatorId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_DestinationObjectId"/>
    public int? DestinationObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_DocumentFolderId"/>
    public int DocumentFolderId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_DocumentNumber"/>
    public string DocumentNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_GenerateNewDocument"/>
    public bool GenerateNewDocument { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_GeneratedDocumentId"/>
    public int GeneratedDocumentId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_HandingOverUserName"/>
    public string HandingOverUserName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_Html"/>
    public string Html { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_Invalidated"/>
    public bool Invalidated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_IssuedDate"/>
    public DateTime IssuedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_ObjectIds"/>
    public string ObjectIds { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_OverwriteLabels"/>
    public bool OverwriteLabels { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_PageSettings"/>
    public PrintPageSettings PageSettings { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_PrintTemplateId"/>
    public int PrintTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_PrintTemplateType"/>
    public ObjectsPrintModel.PrintTemplateType PrintTemplateType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_RecipientUserName"/>
    public string RecipientUserName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_SourceObjectId"/>
    public int? SourceObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_Text"/>
    public string Text { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.GeneratePdfModel.html#Alvao_API_AM_Model_Print_GeneratePdfModel_TransferConfirmType"/>
    public int TransferConfirmType { get; set; }
}
