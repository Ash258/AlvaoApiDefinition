using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detection of SW - information on the operating system.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblOsVersionInfo.htm"/>
[TableAttribute("dbo.tblOsVersionInfo")]
public class tblOsVersionInfo
{
    public virtual int? intBuildNumber { get; set; }
    public virtual int? intMajorVersion { get; set; }
    public virtual int? intMinorVersion { get; set; }
    public virtual int? intPlatformId { get; set; }
    public virtual int? intProductType { get; set; }
    public virtual int? intServicePackMajor { get; set; }
    public virtual int? intServicePackMinor { get; set; }
    public virtual int? intSuiteMask { get; set; }
    [ExplicitKeyAttribute]
    public virtual int lintDetectId { get; set; }
    public virtual string txtCSDVersion { get; set; }

    public tblOsVersionInfo() { }
}
