namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwScanPayloadDto.html"/>
public record SwScanPayloadDto : IEquatable<SwScanPayloadDto> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwScanPayloadDto.html#Alvao_API_AM_Model_SwLibrary_SwScanPayloadDto_ComputerInfo"/>
    public object ComputerInfo { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwScanPayloadDto.html#Alvao_API_AM_Model_SwLibrary_SwScanPayloadDto_FormatVersion"/>
    public int FormatVersion { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwScanPayloadDto.html#Alvao_API_AM_Model_SwLibrary_SwScanPayloadDto_ScanInfo"/>
    public object ScanInfo { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwScanPayloadDto.html#Alvao_API_AM_Model_SwLibrary_SwScanPayloadDto_Software"/>
    public SwSoftwareDto Software { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwScanPayloadDto.html#Alvao_API_AM_Model_SwLibrary_SwScanPayloadDto__ctor_System_Int32_System_Object_System_Object_Alvao_API_AM_Model_SwLibrary_SwSoftwareDto_"/>
    public SwScanPayloadDto(int FormatVersion, object ScanInfo, object ComputerInfo, SwSoftwareDto Software) { }
}
