using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection of SW - information on the operating system.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblOsVersionInfo.htm"/>
[TableAttribute("dbo.tblOsVersionInfo")]
public class tblOsVersionInfo {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_intBuildNumber.htm"/>
    public virtual int? intBuildNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_intMajorVersion.htm"/>
    public virtual int? intMajorVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_intMinorVersion.htm"/>
    public virtual int? intMinorVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_intPlatformId.htm"/>
    public virtual int? intPlatformId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_intProductType.htm"/>
    public virtual int? intProductType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_intServicePackMajor.htm"/>
    public virtual int? intServicePackMajor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_intServicePackMinor.htm"/>
    public virtual int? intServicePackMinor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_intSuiteMask.htm"/>
    public virtual int? intSuiteMask { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_lintDetectId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblOsVersionInfo_txtCSDVersion.htm"/>
    public virtual string txtCSDVersion { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblOsVersionInfo__ctor.htm"/>
    public tblOsVersionInfo() { }
}
