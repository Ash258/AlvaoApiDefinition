using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection of SW - information on the operating system.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html"/>
[Table("dbo.tblOsVersionInfo")]
public class tblOsVersionInfo {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intBuildNumber"/>
    public virtual int? intBuildNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intMajorVersion"/>
    public virtual int? intMajorVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intMinorVersion"/>
    public virtual int? intMinorVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intPlatformId"/>
    public virtual int? intPlatformId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intProductType"/>
    public virtual int? intProductType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intServicePackMajor"/>
    public virtual int? intServicePackMajor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intServicePackMinor"/>
    public virtual int? intServicePackMinor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_intSuiteMask"/>
    public virtual int? intSuiteMask { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_lintDetectId"/>
    [ExplicitKey]
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblOsVersionInfo.html#Alvao_API_Common_Model_Database_tblOsVersionInfo_txtCSDVersion"/>
    public virtual string txtCSDVersion { get; set; }
}
