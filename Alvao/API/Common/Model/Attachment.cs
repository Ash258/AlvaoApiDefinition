using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html"/>
public class Attachment : IAttachment {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment_ContentType"/>
    public string ContentType { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment_DocumentId"/>
    public int? DocumentId { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment_EmbeddedImage"/>
    public bool EmbeddedImage { get; }
    /// <summary>Attachment name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment_Name"/>
    public string Name { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment_UniqueName"/>
    public Guid UniqueName { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment_Url"/>
    public string Url { get; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment__ctor_Alvao_API_Common_Model_Database_tDocument_System_Guid_"/>
    public Attachment(tDocument document, Guid uniqueId) { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment_GetStream"/>
    public Stream GetStream() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Attachment.html#Alvao_API_Common_Model_Attachment_ToLinkedResource"/>
    public LinkedResource ToLinkedResource() { throw new NotImplementedException(); }
}
