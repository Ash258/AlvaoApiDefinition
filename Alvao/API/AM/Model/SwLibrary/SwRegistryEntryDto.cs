namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryEntryDto.html"/>
public record SwRegistryEntryDto : IEquatable<SwRegistryEntryDto> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryEntryDto.html#Alvao_API_AM_Model_SwLibrary_SwRegistryEntryDto_Path"/>
    public string? Path { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryEntryDto.html#Alvao_API_AM_Model_SwLibrary_SwRegistryEntryDto_Type"/>
    public long? Type { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryEntryDto.html#Alvao_API_AM_Model_SwLibrary_SwRegistryEntryDto_Values"/>
    public Dictionary<string, object>? Values { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryEntryDto.html#Alvao_API_AM_Model_SwLibrary_SwRegistryEntryDto__ctor_System_Nullable_System_Int64__System_String_System_Collections_Generic_Dictionary_System_String_System_Object__"/>
    public SwRegistryEntryDto(long? Type, string? Path, Dictionary<string, object>? Values = null) { }
}
