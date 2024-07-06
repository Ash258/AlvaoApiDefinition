namespace Alvao.API.Common.Model;

/// <summary>
/// Attachment interface.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_IAttachment.htm"/>
public interface IAttachment
{
    string ContentType { get; }
    int? DocumentId { get; }
    bool EmbeddedImage { get; }
    /// <summary>Attachment name</summary>
    string Name { get; }
    Guid UniqueName { get; }
    string Url { get; }


    Stream GetStream();
}
