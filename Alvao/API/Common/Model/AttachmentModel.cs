namespace Alvao.API.Common.Model;

/// <summary>
/// Wrapper for attachment.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_AttachmentModel.htm"/>
public class AttachmentModel : IAttachment
{
    /// <summary>Attachment content type.</summary>
    public string ContentType { get; set; }
    /// <summary>DB document ID (tDocument.iDocumentId).</summary>
    public int? DocumentId { get; set; }
    /// <summary>Is attachment embedded image?</summary>
    public bool EmbeddedImage { get; set; }
    /// <summary>Attachment name</summary>
    public string Name { get; set; }
    /// <summary>Original attachment (passed in constructor).</summary>
    public IAttachment OriginalAttachment { get; }
    /// <summary>Attachment GUID.</summary>
    public Guid UniqueName { get; set; }
    /// <summary>Attachment URL (set when attachment is link).</summary>
    public string Url { get; set; }

    /// <summary>Creates new AttachmentModel instance.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_AttachmentModel__ctor.htm"/>
    public AttachmentModel(
IAttachment source
)
    { }

    /// <summary>Returns original attachment stream.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_AttachmentModel_GetStream.htm"/>
    public Stream GetStream() { throw new System.NotImplementedException(); }
}
