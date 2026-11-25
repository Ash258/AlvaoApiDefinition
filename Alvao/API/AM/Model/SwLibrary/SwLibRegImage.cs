using System.Runtime.Serialization;
using Alvao.API.Utils;

namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html"/>
[DataContract]
public class SwLibRegImage : SwLibBase {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_Comments"/>
    [DataMember(Name = "comments")]
    public string Comments { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_DisplayName"/>
    [DataMember(Name = "displayName")]
    public string DisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_DisplayVersion"/>
    [DataMember(Name = "displayVersion")]
    public string DisplayVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_IsKeyRule"/>
    [DataMember(Name = "isKeyRule")]
    public bool IsKeyRule { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_LanguageLcid"/>
    [DataMember(Name = "languageLcid")]
    public int? LanguageLcid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_Order"/>
    [DataMember(Name = "order")]
    public int? Order { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_Path"/>
    [DataMember(Name = "path")]
    public string Path { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_ProductUid"/>
    [DataMember(Name = "productUid")]
    public int ProductUid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_Publisher"/>
    [DataMember(Name = "publisher")]
    public string Publisher { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_VersionMajorHi"/>
    [DataMember(Name = "versionMajorHi")]
    public int? VersionMajorHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_VersionMajorLo"/>
    [DataMember(Name = "versionMajorLo")]
    public int? VersionMajorLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_VersionMinorHi"/>
    [DataMember(Name = "versionMinorHi")]
    public int? VersionMinorHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_VersionMinorLo"/>
    [DataMember(Name = "versionMinorLo")]
    public int? VersionMinorLo { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage__ctor"/>
    public SwLibRegImage() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibRegImage(ArchiveStream ar) { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_WriteToArchive_Alvao_API_Utils_ArchiveStream_"/>
    public override void WriteToArchive(ArchiveStream archiveStream) { throw new NotImplementedException(); }
}
