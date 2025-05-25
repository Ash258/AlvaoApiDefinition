namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html"/>
public class SwLibRegImage : SwLibBase {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_Comments"/>
    public string Comments { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_DisplayName"/>
    public string DisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_DisplayVersion"/>
    public string DisplayVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_IsKeyRule"/>
    public bool IsKeyRule { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_LanguageLcid"/>
    public int? LanguageLcid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_Order"/>
    public int? Order { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_Path"/>
    public string Path { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_ProductUid"/>
    public int ProductUid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_Publisher"/>
    public string Publisher { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_VersionMajorHi"/>
    public int? VersionMajorHi { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_VersionMajorLo"/>
    public int? VersionMajorLo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_VersionMinorHi"/>
    public int? VersionMinorHi { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage_VersionMinorLo"/>
    public int? VersionMinorLo { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage__ctor"/>
    public SwLibRegImage() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibRegImage.html#Alvao_API_AM_Model_SwLibrary_SwLibRegImage__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibRegImage(ArchiveStream ar) { }
}
