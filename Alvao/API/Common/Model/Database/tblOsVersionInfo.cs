using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection of SW - information on the operating system.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html"/>
[Table("dbo.tblOsVersionInfo")]
public class tblOsVersionInfo {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intBuildNumber"/>
    /// <remarks>Column <c>intBuildNumber</c>: int, null.</remarks>
    public virtual int? intBuildNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intMajorVersion"/>
    /// <remarks>Column <c>intMajorVersion</c>: int, null.</remarks>
    public virtual int? intMajorVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intMinorVersion"/>
    /// <remarks>Column <c>intMinorVersion</c>: int, null.</remarks>
    public virtual int? intMinorVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intPlatformId"/>
    /// <remarks>Column <c>intPlatformId</c>: int, null.</remarks>
    public virtual int? intPlatformId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intProductType"/>
    /// <remarks>Column <c>intProductType</c>: int, null.</remarks>
    public virtual int? intProductType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intServicePackMajor"/>
    /// <remarks>Column <c>intServicePackMajor</c>: int, null.</remarks>
    public virtual int? intServicePackMajor { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intServicePackMinor"/>
    /// <remarks>Column <c>intServicePackMinor</c>: int, null.</remarks>
    public virtual int? intServicePackMinor { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intSuiteMask"/>
    /// <remarks>Column <c>intSuiteMask</c>: int, null.</remarks>
    public virtual int? intSuiteMask { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_lintDetectId"/>
    /// <remarks>Column <c>lintDetectId</c>: int, not null. References <see cref="tblDetect"/>.</remarks>
    [ExplicitKey]
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_txtCSDVersion"/>
    /// <remarks>Column <c>txtCSDVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtCSDVersion { get; set; }
}
