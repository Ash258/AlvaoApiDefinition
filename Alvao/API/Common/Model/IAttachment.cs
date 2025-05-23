namespace Alvao.API.Common.Model;

/// <summary>Attachment interface.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_IAttachment.htm"/>
public interface IAttachment {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_IAttachment_ContentType.htm"/>
    string ContentType { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_IAttachment_DocumentId.htm"/>
    int? DocumentId { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_IAttachment_EmbeddedImage.htm"/>
    bool EmbeddedImage { get; }
    /// <summary>Attachment name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_IAttachment_Name.htm"/>
    string Name { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_IAttachment_UniqueName.htm"/>
    Guid UniqueName { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_IAttachment_Url.htm"/>
    string Url { get; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_IAttachment_GetStream.htm"/>
    Stream GetStream();
}
