using Alvao.API.Common.Model;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html"/>
public class LinksModel : IAttachment {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html#Alvao_API_AM_Model_LinksModel_ContentType"/>
    public string ContentType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html#Alvao_API_AM_Model_LinksModel_DocumentId"/>
    public int? DocumentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html#Alvao_API_AM_Model_LinksModel_EmbeddedImage"/>
    public bool EmbeddedImage { get; set; }
    /// <summary>Attachment name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html#Alvao_API_AM_Model_LinksModel_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html#Alvao_API_AM_Model_LinksModel_UniqueName"/>
    public Guid UniqueName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html#Alvao_API_AM_Model_LinksModel_Url"/>
    public string Url { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html#Alvao_API_AM_Model_LinksModel__ctor_System_String_System_Guid_"/>
    public LinksModel(string url, Guid guid) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.LinksModel.html#Alvao_API_AM_Model_LinksModel_GetStream"/>
    public Stream GetStream() { throw new NotImplementedException(); }
}
