using Alvao.API.Common.Model.Database;
using Microsoft.Extensions.Logging;

namespace Alvao.API.Common.Model;

/// <summary>Wrapper for attachment.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html"/>
public class AttachmentModel : IAttachment {
    /// <summary>Attachment content type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_ContentType"/>
    public string ContentType { get; set; }
    /// <summary>DB document ID (tDocument.iDocumentId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_DocumentId"/>
    public int? DocumentId { get; set; }
    /// <summary>Is attachment embedded image?</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_EmbeddedImage"/>
    public bool EmbeddedImage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_Log"/>
    protected ILogger Log { get; set; }
    /// <summary>Attachment name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_Name"/>
    public string Name { get; set; }
    /// <summary>Original attachment (passed in constructor).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_OriginalAttachment"/>
    public IAttachment OriginalAttachment { get; protected set; }
    /// <summary>Attachment GUID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_UniqueName"/>
    public Guid UniqueName { get; set; }
    /// <summary>Attachment URL (set when attachment is link).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_Url"/>
    public string Url { get; set; }

    /// <summary>Creates new AttachmentModel instance.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel__ctor_Alvao_API_Common_Model_IAttachment_"/>
    /// <param name="source">Attachment</param>
    public AttachmentModel(IAttachment source) { }

    /// <summary>Returns original attachment stream.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_GetStream"/>
    public Stream GetStream() { throw new System.NotImplementedException(); }
    /// <summary>Saves attachment to database (tDocument using documentRepository)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AttachmentModel.html#Alvao_API_Common_Model_AttachmentModel_SaveToDB_Alvao_API_Common_Repository_IDocumentRepository_"/>
    /// <param name="documentRepository">Document repository</param>
    public void SaveToDB(IDocumentRepository documentRepository) { throw new System.NotImplementedException(); }
}
