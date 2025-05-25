namespace Alvao.API.AM.Model.Detection.Software;

/// <summary>
/// OSVERSIONINFOA and OSVERSIONINFOEXA structure emulation https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-osversioninfoa
///               https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-osversioninfoexa
/// </summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html"/>
public class OsVersionInfo {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_IsExtendedStructure"/>
    public bool IsExtendedStructure { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwBuildNumber"/>
    public uint dwBuildNumber { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwMajorVersion"/>
    public uint dwMajorVersion { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwMinorVersion"/>
    public uint dwMinorVersion { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwOSVersionInfoSize"/>
    public uint dwOSVersionInfoSize { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwPlatformId"/>
    public uint dwPlatformId { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_szCSDVersion"/>
    public string szCSDVersion { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wProductType"/>
    public byte wProductType { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wReserved"/>
    public byte wReserved { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wServicePackMajor"/>
    public short wServicePackMajor { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wServicePackMinor"/>
    public short wServicePackMinor { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wSuiteMask"/>
    public short wSuiteMask { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo__ctor_Alvao_API_AM_Model_Detection_DetectionArchive_System_Boolean_"/>
    public OsVersionInfo(DetectionArchive ar, bool isExInfo) { }
}
