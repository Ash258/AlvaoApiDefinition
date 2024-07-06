using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Records on installation and uninstallation of products on the computers (manual as well as detected)
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInstHist.htm"/>
[TableAttribute("dbo.tblInstHist")]
public class tblInstHist
{
    /// <summary>Date on which the installation was detected</summary>
    public virtual DateTime? dteInstallDetected { get; set; }
    /// <summary>Installed</summary>
    public virtual DateTime? dteInstalled { get; set; }
    /// <summary>Date on which the uninstallation was detected</summary>
    public virtual DateTime? dteUninstallDetected { get; set; }
    /// <summary>Uninstalled</summary>
    public virtual DateTime? dteUninstalled { get; set; }
    /// <summary>Date of manual or detected installation of the product.</summary>
    public virtual DateTime? Installed { get; set; }
    /// <summary>Detection product language - LCID</summary>
    public virtual int? intDetLanguage { get; set; }
    /// <summary>installation id</summary>
    [KeyAttribute]
    public virtual int intInstHistId { get; set; }
    /// <summary>Installed by - tPerson</summary>
    public virtual int? liInstalledPersonId { get; set; }
    /// <summary>Computer - tblNode</summary>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>Which detection detected the installation - tblDetect</summary>
    public virtual int? lintInstallDetectId { get; set; }
    /// <summary>Product - tblProduct</summary>
    public virtual int lintProductId { get; set; }
    /// <summary>Which detection detected the uninstallation - tblDetect</summary>
    public virtual int? lintUnistallDetectId { get; set; }
    /// <summary>Uninstalled by - tPerson</summary>
    public virtual int? liUninstalledPersonId { get; set; }
    /// <summary>Detected CD-Key</summary>
    public virtual string txtDetCDKey { get; set; }
    /// <summary>Detected installation date</summary>
    public virtual string txtDetInstallDate { get; set; }
    /// <summary>Detected Product-ID</summary>
    public virtual string txtDetProductId { get; set; }
    /// <summary>Name of detected product</summary>
    public virtual string txtDetProductName { get; set; }
    /// <summary>Version of detected product</summary>
    public virtual string txtDetProductVersion { get; set; }
    /// <summary>Recognized by</summary>
    public virtual string txtDetRecognizedBy { get; set; }
    /// <summary>Note</summary>
    public virtual string txtMemo { get; set; }
    /// <summary>Date of manual or detected uninstallation of the product.</summary>
    public virtual DateTime? Uninstalled { get; set; }

    public tblInstHist() { }
}
