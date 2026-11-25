namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFolderDto.html"/>
public record SwFolderDto : IEquatable<SwFolderDto> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFolderDto.html#Alvao_API_AM_Model_SwLibrary_SwFolderDto_Files"/>
    public SwFileDto[] Files { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFolderDto.html#Alvao_API_AM_Model_SwLibrary_SwFolderDto_Path"/>
    public string Path { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFolderDto.html#Alvao_API_AM_Model_SwLibrary_SwFolderDto__ctor_System_String_Alvao_API_AM_Model_SwLibrary_SwFileDto___"/>
    public SwFolderDto(string Path, SwFileDto[] Files) { }
}
