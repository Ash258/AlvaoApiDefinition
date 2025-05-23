namespace Alvao.API.Common.Model;

/// <summary>Wrapper for attachment.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_AttachmentModel.htm"/>
public class AttachmentModel : IAttachment {
    /// <summary>Attachment content type.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AttachmentModel_ContentType.htm"/>
    public string ContentType { get; set; }
    /// <summary>DB document ID (tDocument.iDocumentId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AttachmentModel_DocumentId.htm"/>
    public int? DocumentId { get; set; }
    /// <summary>Is attachment embedded image?</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AttachmentModel_EmbeddedImage.htm"/>
    public bool EmbeddedImage { get; set; }
    /// <summary>Attachment name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AttachmentModel_Name.htm"/>
    public string Name { get; set; }
    /// <summary>Original attachment (passed in constructor).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AttachmentModel_OriginalAttachment.htm"/>
    public IAttachment OriginalAttachment { get; }
    /// <summary>Attachment GUID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AttachmentModel_UniqueName.htm"/>
    public Guid UniqueName { get; set; }
    /// <summary>Attachment URL (set when attachment is link).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AttachmentModel_Url.htm"/>
    public string Url { get; set; }

    /// <summary>Creates new AttachmentModel instance.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_AttachmentModel__ctor.htm"/>
    public AttachmentModel(
        IAttachment source
    ) { }

    /// <summary>Returns original attachment stream.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_AttachmentModel_GetStream.htm"/>
    public Stream GetStream() { throw new System.NotImplementedException(); }
}
