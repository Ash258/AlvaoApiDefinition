using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Installed software - valid products and outside system objects.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInst.htm"/>
[TableAttribute("dbo.vSwInst")]
public class vSwInst
{
    public virtual DateTime? dteInstallDetected { get; set; }
    public virtual DateTime? dteInstalled { get; set; }
    public virtual DateTime? dteUninstallDetected { get; set; }
    public virtual DateTime? dteUninstalled { get; set; }
    public virtual int? intDetLanguage { get; set; }
    public virtual int intInstHistId { get; set; }
    public virtual int? liInstalledPersonId { get; set; }
    public virtual int lintComputerNodeId { get; set; }
    public virtual int? lintInstallDetectId { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual int? lintUnistallDetectId { get; set; }
    public virtual int? liUninstalledPersonId { get; set; }
    public virtual string txtDetCDKey { get; set; }
    public virtual string txtDetInstallDate { get; set; }
    public virtual string txtDetProductId { get; set; }
    public virtual string txtDetProductName { get; set; }
    public virtual string txtDetProductVersion { get; set; }
    public virtual string txtDetRecognizedBy { get; set; }
    public virtual string txtMemo { get; set; }

    public vSwInst() { }
}
