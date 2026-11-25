namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html"/>
public record SwFileVerInfoDto : IEquatable<SwFileVerInfoDto> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_Comments"/>
    public string? Comments { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_CompanyName"/>
    public string? CompanyName { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_FileDescription"/>
    public string? FileDescription { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_FileVersion"/>
    public string? FileVersion { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_FileVersionMajor"/>
    public int? FileVersionMajor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_FileVersionMinor"/>
    public int? FileVersionMinor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_InternalName"/>
    public string? InternalName { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_Language"/>
    public int? Language { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_LegalCopyright"/>
    public string? LegalCopyright { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_LegalTrademarks"/>
    public string? LegalTrademarks { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_OriginalFilename"/>
    public string? OriginalFilename { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_PrivateBuild"/>
    public string? PrivateBuild { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_ProductName"/>
    public string? ProductName { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_ProductVersion"/>
    public string? ProductVersion { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_ProductVersionMajor"/>
    public int? ProductVersionMajor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_ProductVersionMinor"/>
    public int? ProductVersionMinor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_SpecialBuild"/>
    public string? SpecialBuild { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileVerInfoDto.html#Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto__ctor_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_Nullable_System_Int32__System_Nullable_System_Int32__System_Nullable_System_Int32__System_Nullable_System_Int32__System_Nullable_System_Int32__"/>
    public SwFileVerInfoDto(string? Comments, string? CompanyName, string? FileDescription, string? FileVersion, string? InternalName, string? LegalCopyright, string? LegalTrademarks, string? OriginalFilename, string? PrivateBuild, string? ProductName, string? ProductVersion, string? SpecialBuild, int? Language, int? FileVersionMajor, int? FileVersionMinor, int? ProductVersionMajor, int? ProductVersionMinor) { }
}
