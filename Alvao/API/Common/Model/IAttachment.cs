namespace Alvao.API.Common.Model;

/// <summary>Attachment interface.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.IAttachment.html"/>
public interface IAttachment {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.IAttachment.html#Alvao_API_Common_Model_IAttachment_ContentType"/>
    string ContentType { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.IAttachment.html#Alvao_API_Common_Model_IAttachment_DocumentId"/>
    int? DocumentId { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.IAttachment.html#Alvao_API_Common_Model_IAttachment_EmbeddedImage"/>
    bool EmbeddedImage { get; }
    /// <summary>Attachment name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.IAttachment.html#Alvao_API_Common_Model_IAttachment_Name"/>
    string Name { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.IAttachment.html#Alvao_API_Common_Model_IAttachment_UniqueName"/>
    Guid UniqueName { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.IAttachment.html#Alvao_API_Common_Model_IAttachment_Url"/>
    string Url { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.IAttachment.html#Alvao_API_Common_Model_IAttachment_GetStream"/>
    Stream GetStream();
}
