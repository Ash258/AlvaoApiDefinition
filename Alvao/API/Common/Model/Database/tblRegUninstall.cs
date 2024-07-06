using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected registry entries. The table contains records which may repeat in various computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblRegUninstall.htm"/>
[TableAttribute("dbo.tblRegUninstall")]
public class tblRegUninstall
{
    public virtual DateTime? EvalSwLibDate { get; set; }
    [ComputedAttribute]
    public virtual string FullName { get; set; }
    public virtual byte[] Hash { get; set; }
    public virtual int? intLanguage { get; set; }
    [KeyAttribute]
    public virtual int intRegUninstallId { get; set; }
    public virtual int? intSystemComponent { get; set; }
    public virtual int? intVersion { get; set; }
    public virtual int? intVersionMajor { get; set; }
    public virtual int? intVersionMinor { get; set; }
    public virtual int? intWindowsInstaller { get; set; }
    public virtual int? lintOriginalProductId { get; set; }
    public virtual int? lintProductId { get; set; }
    public virtual int? lintRegImageId { get; set; }
    public virtual int lintRootRegKeyId { get; set; }
    public virtual string txtAuthorizedCDFPrefix { get; set; }
    public virtual string txtComments { get; set; }
    public virtual string txtContact { get; set; }
    public virtual string txtDisplayName { get; set; }
    public virtual string txtDisplayVersion { get; set; }
    public virtual string txtHelpLink { get; set; }
    public virtual string txtHelpTelephone { get; set; }
    public virtual string txtPath { get; set; }
    public virtual string txtPublisher { get; set; }
    public virtual string txtSize { get; set; }
    public virtual string txtURLInfoAbout { get; set; }
    public virtual string txtURLUpdateInfo { get; set; }

    public tblRegUninstall() { }
}
