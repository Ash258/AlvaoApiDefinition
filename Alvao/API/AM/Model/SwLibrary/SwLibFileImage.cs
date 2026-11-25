using System.Runtime.Serialization;
using Alvao.API.Utils;

namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html"/>
[DataContract]
public class SwLibFileImage : SwLibBase {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_Codepage"/>
    [DataMember(Name = "codepage")]
    public int? Codepage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_Comments"/>
    [DataMember(Name = "comments")]
    public string Comments { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_CompanyName"/>
    [DataMember(Name = "companyName")]
    public string CompanyName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_Ext"/>
    [DataMember(Name = "ext")]
    public string Ext { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_FileDesc"/>
    [DataMember(Name = "fileDesc")]
    public string FileDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_FileVerLsHi"/>
    [DataMember(Name = "fileVerLsHi")]
    public int? FileVerLsHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_FileVerLsLo"/>
    [DataMember(Name = "fileVerLsLo")]
    public int? FileVerLsLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_FileVerMsHi"/>
    [DataMember(Name = "fileVerMsHi")]
    public int? FileVerMsHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_FileVerMsLo"/>
    [DataMember(Name = "fileVerMsLo")]
    public int? FileVerMsLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_FileVersion"/>
    [DataMember(Name = "fileVersion")]
    public string FileVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_InternalName"/>
    [DataMember(Name = "internalName")]
    public string InternalName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_IsKeyRule"/>
    [DataMember(Name = "isKeyRule")]
    public bool IsKeyRule { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_LanguageLcid"/>
    [DataMember(Name = "languageLcid")]
    public int? LanguageLcid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_LegalCopyright"/>
    [DataMember(Name = "legalCopyright")]
    public string LegalCopyright { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_LegalTrademark"/>
    [DataMember(Name = "legalTrademark")]
    public string LegalTrademark { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_Name"/>
    [DataMember(Name = "name")]
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_Order"/>
    [DataMember(Name = "order")]
    public int? Order { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_OriginalFilename"/>
    [DataMember(Name = "originalFilename")]
    public string OriginalFilename { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_PrivateBuild"/>
    [DataMember(Name = "privateBuild")]
    public string PrivateBuild { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_ProductName"/>
    [DataMember(Name = "productName")]
    public string ProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_ProductUid"/>
    [DataMember(Name = "productUid")]
    public int ProductUid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_ProductVerLsHi"/>
    [DataMember(Name = "productVerLsHi")]
    public int? ProductVerLsHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_ProductVerLsLo"/>
    [DataMember(Name = "productVerLsLo")]
    public int? ProductVerLsLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_ProductVerMsHi"/>
    [DataMember(Name = "productVerMsHi")]
    public int? ProductVerMsHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_ProductVerMsLo"/>
    [DataMember(Name = "productVerMsLo")]
    public int? ProductVerMsLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_ProductVersion"/>
    [DataMember(Name = "productVersion")]
    public string ProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_Size"/>
    [DataMember(Name = "size")]
    public int? Size { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_SpecialBuild"/>
    [DataMember(Name = "specialBuild")]
    public string SpecialBuild { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage__ctor"/>
    public SwLibFileImage() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibFileImage(ArchiveStream ar) { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibFileImage.html#Alvao_API_AM_Model_SwLibrary_SwLibFileImage_WriteToArchive_Alvao_API_Utils_ArchiveStream_"/>
    public override void WriteToArchive(ArchiveStream archiveStream) { throw new NotImplementedException(); }
}
