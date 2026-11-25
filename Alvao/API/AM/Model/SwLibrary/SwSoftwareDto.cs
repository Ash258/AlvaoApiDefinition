namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwSoftwareDto.html"/>
public record SwSoftwareDto : IEquatable<SwSoftwareDto> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwSoftwareDto.html#Alvao_API_AM_Model_SwLibrary_SwSoftwareDto_FileList"/>
    public SwFolderDto[] FileList { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwSoftwareDto.html#Alvao_API_AM_Model_SwLibrary_SwSoftwareDto_OsVersionInfoEx"/>
    public SwOsVersionInfoExDto? OsVersionInfoEx { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwSoftwareDto.html#Alvao_API_AM_Model_SwLibrary_SwSoftwareDto_RegistryList"/>
    public SwRegistryEntryDto[] RegistryList { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwSoftwareDto.html#Alvao_API_AM_Model_SwLibrary_SwSoftwareDto__ctor_Alvao_API_AM_Model_SwLibrary_SwOsVersionInfoExDto_Alvao_API_AM_Model_SwLibrary_SwRegistryEntryDto___Alvao_API_AM_Model_SwLibrary_SwFolderDto___"/>
    public SwSoftwareDto(SwOsVersionInfoExDto? OsVersionInfoEx, SwRegistryEntryDto[] RegistryList, SwFolderDto[] FileList) { }
}
