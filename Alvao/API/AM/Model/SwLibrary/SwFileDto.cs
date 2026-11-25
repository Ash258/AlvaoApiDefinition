namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html"/>
public record SwFileDto : IEquatable<SwFileDto> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_Accessed"/>
    public DateTime Accessed { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_Attributes"/>
    public int Attributes { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_Created"/>
    public DateTime Created { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_FileVerInfo"/>
    public SwFileVerInfoDto? FileVerInfo { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_Filename"/>
    public string Filename { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_LastRun"/>
    public DateTime? LastRun { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_Modified"/>
    public DateTime Modified { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_RunCount"/>
    public int? RunCount { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto_Size"/>
    public long Size { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileDto.html#Alvao_API_AM_Model_SwLibrary_SwFileDto__ctor_System_String_System_Int64_System_Int32_System_DateTime_System_DateTime_System_DateTime_System_Nullable_System_DateTime__System_Nullable_System_Int32__Alvao_API_AM_Model_SwLibrary_SwFileVerInfoDto_"/>
    public SwFileDto(string Filename, long Size, int Attributes, DateTime Created, DateTime Modified, DateTime Accessed, DateTime? LastRun, int? RunCount, SwFileVerInfoDto? FileVerInfo) { }
}
