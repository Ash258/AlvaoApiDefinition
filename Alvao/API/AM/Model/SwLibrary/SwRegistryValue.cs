namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryValue.html"/>
public class SwRegistryValue {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryValue.html#Alvao_API_AM_Model_SwLibrary_SwRegistryValue_RegKey"/>
    public string? RegKey { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryValue.html#Alvao_API_AM_Model_SwLibrary_SwRegistryValue_RegKeyId"/>
    public int RegKeyId { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryValue.html#Alvao_API_AM_Model_SwLibrary_SwRegistryValue_RegPath"/>
    public string RegPath { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwRegistryValue.html#Alvao_API_AM_Model_SwLibrary_SwRegistryValue_RegValue"/>
    public string? RegValue { get; init; }
}
