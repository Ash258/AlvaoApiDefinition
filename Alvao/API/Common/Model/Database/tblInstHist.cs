using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Records on installation and uninstallation of products on the computers (manual as well as detected)</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInstHist.htm"/>
[TableAttribute("dbo.tblInstHist")]
public class tblInstHist {
    /// <summary>Date on which the installation was detected</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_dteInstallDetected.htm"/>
    public virtual DateTime? dteInstallDetected { get; set; }
    /// <summary>Installed</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_dteInstalled.htm"/>
    public virtual DateTime? dteInstalled { get; set; }
    /// <summary>Date on which the uninstallation was detected</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_dteUninstallDetected.htm"/>
    public virtual DateTime? dteUninstallDetected { get; set; }
    /// <summary>Uninstalled</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_dteUninstalled.htm"/>
    public virtual DateTime? dteUninstalled { get; set; }
    /// <summary>Date of manual or detected installation of the product.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_Installed.htm"/>
    public virtual DateTime? Installed { get; set; }
    /// <summary>Detection product language - LCID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_intDetLanguage.htm"/>
    public virtual int? intDetLanguage { get; set; }
    /// <summary>installation id</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_intInstHistId.htm"/>
    [KeyAttribute]
    public virtual int intInstHistId { get; set; }
    /// <summary>Installed by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_liInstalledPersonId.htm"/>
    public virtual int? liInstalledPersonId { get; set; }
    /// <summary>Computer - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>Which detection detected the installation - tblDetect</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_lintInstallDetectId.htm"/>
    public virtual int? lintInstallDetectId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }
    /// <summary>Which detection detected the uninstallation - tblDetect</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_lintUnistallDetectId.htm"/>
    public virtual int? lintUnistallDetectId { get; set; }
    /// <summary>Uninstalled by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_liUninstalledPersonId.htm"/>
    public virtual int? liUninstalledPersonId { get; set; }
    /// <summary>Detected CD-Key</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_txtDetCDKey.htm"/>
    public virtual string txtDetCDKey { get; set; }
    /// <summary>Detected installation date</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_txtDetInstallDate.htm"/>
    public virtual string txtDetInstallDate { get; set; }
    /// <summary>Detected Product-ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_txtDetProductId.htm"/>
    public virtual string txtDetProductId { get; set; }
    /// <summary>Name of detected product</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_txtDetProductName.htm"/>
    public virtual string txtDetProductName { get; set; }
    /// <summary>Version of detected product</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_txtDetProductVersion.htm"/>
    public virtual string txtDetProductVersion { get; set; }
    /// <summary>Recognized by</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_txtDetRecognizedBy.htm"/>
    public virtual string txtDetRecognizedBy { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }
    /// <summary>Date of manual or detected uninstallation of the product.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstHist_Uninstalled.htm"/>
    public virtual DateTime? Uninstalled { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblInstHist__ctor.htm"/>
    public tblInstHist() { }
}
