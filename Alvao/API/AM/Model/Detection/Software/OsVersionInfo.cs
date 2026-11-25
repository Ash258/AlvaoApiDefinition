using System.Runtime.Serialization;

namespace Alvao.API.AM.Model.Detection.Software;

/// <summary>
/// OSVERSIONINFOA and OSVERSIONINFOEXA structure emulation
/// https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-osversioninfoa
/// https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-osversioninfoexa
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html"/>
[DataContract]
public class OsVersionInfo {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_IsExtendedStructure"/>
    public bool IsExtendedStructure;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwBuildNumber"/>
    [DataMember(Name = "dwBuildNumber")]
    public uint dwBuildNumber;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwMajorVersion"/>
    [DataMember(Name = "dwMajorVersion")]
    public uint dwMajorVersion;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwMinorVersion"/>
    [DataMember(Name = "dwMinorVersion")]
    public uint dwMinorVersion;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwOSVersionInfoSize"/>
    [DataMember(Name = "dwOSVersionInfoSize")]
    public uint dwOSVersionInfoSize;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_dwPlatformId"/>
    [DataMember(Name = "dwPlatformId")]
    public uint dwPlatformId;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_szCSDVersion"/>
    [DataMember(Name = "szCSDVersion")]
    public string szCSDVersion;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wProductType"/>
    [DataMember(Name = "wProductType")]
    public int wProductType;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wReserved"/>
    [DataMember(Name = "wReserved")]
    public byte wReserved;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wServicePackMajor"/>
    [DataMember(Name = "wServicePackMajor")]
    public short wServicePackMajor;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wServicePackMinor"/>
    [DataMember(Name = "wServicePackMinor")]
    public short wServicePackMinor;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo_wSuiteMask"/>
    [DataMember(Name = "wSuiteMask")]
    public int wSuiteMask;

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo__ctor"/>
    public OsVersionInfo() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Software.OsVersionInfo.html#Alvao_API_AM_Model_Detection_Software_OsVersionInfo__ctor_Alvao_API_AM_Model_Detection_DetectionArchive_System_Boolean_"/>
    public OsVersionInfo(DetectionArchive ar, bool isExInfo) { }
}
