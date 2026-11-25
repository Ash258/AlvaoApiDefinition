namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html"/>
public class SwFileRow {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_Accessed"/>
    public DateTime Accessed { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_Attributes"/>
    public int Attributes { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_Comments"/>
    public string? Comments { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_CompanyName"/>
    public string? CompanyName { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_Created"/>
    public DateTime Created { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_Extension"/>
    public string Extension { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_FileDescription"/>
    public string? FileDescription { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_FileName"/>
    public string FileName { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_FileVersion"/>
    public string? FileVersion { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_FileVersionMajor"/>
    public int? FileVersionMajor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_FileVersionMinor"/>
    public int? FileVersionMinor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_FolderPath"/>
    public string FolderPath { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_InternalName"/>
    public string? InternalName { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_Language"/>
    public int? Language { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_LastRun"/>
    public DateTime? LastRun { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_LegalCopyright"/>
    public string? LegalCopyright { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_LegalTrademarks"/>
    public string? LegalTrademarks { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_Modified"/>
    public DateTime Modified { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_OriginalFilename"/>
    public string? OriginalFilename { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_PrivateBuild"/>
    public string? PrivateBuild { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_ProductName"/>
    public string? ProductName { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_ProductVersion"/>
    public string? ProductVersion { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_ProductVersionMajor"/>
    public int? ProductVersionMajor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_ProductVersionMinor"/>
    public int? ProductVersionMinor { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_RunCount"/>
    public int? RunCount { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_Size"/>
    public long Size { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwFileRow.html#Alvao_API_AM_Model_SwLibrary_SwFileRow_SpecialBuild"/>
    public string? SpecialBuild { get; init; }
}
