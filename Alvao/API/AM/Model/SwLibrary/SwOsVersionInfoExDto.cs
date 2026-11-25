namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html"/>
public record SwOsVersionInfoExDto : IEquatable<SwOsVersionInfoExDto> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_DwBuildNumber"/>
    public int DwBuildNumber { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_DwMajorVersion"/>
    public int DwMajorVersion { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_DwMinorVersion"/>
    public int DwMinorVersion { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_DwPlatformId"/>
    public int DwPlatformId { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_SzCSDVersion"/>
    public string SzCSDVersion { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_WProductType"/>
    public int WProductType { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_WServicePackMajor"/>
    public int WServicePackMajor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_WServicePackMinor"/>
    public int WServicePackMinor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_WSuiteMask"/>
    public int WSuiteMask { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwOsVersionInfoExDto.html#Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto__ctor_System_Int32_System_Int32_System_Int32_System_Int32_System_String_System_Int32_System_Int32_System_Int32_System_Int32_"/>
    public SwOsVersionInfoExDto(int DwMajorVersion, int DwMinorVersion, int DwBuildNumber, int DwPlatformId, string SzCSDVersion, int WServicePackMajor, int WServicePackMinor, int WSuiteMask, int WProductType) { }
}
