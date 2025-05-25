using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Records on installation and uninstallation of products on the computers (manual as well as detected)</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html"/>
[Table("dbo.tblInstHist")]
public class tblInstHist {
    /// <summary>Date of manual or detected installation of the product.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_Installed"/>
    public virtual DateTime? Installed { get; set; }
    /// <summary>Date of manual or detected uninstallation of the product.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_Uninstalled"/>
    public virtual DateTime? Uninstalled { get; set; }
    /// <summary>Date on which the installation was detected</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_dteInstallDetected"/>
    public virtual DateTime? dteInstallDetected { get; set; }
    /// <summary>Installed</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_dteInstalled"/>
    public virtual DateTime? dteInstalled { get; set; }
    /// <summary>Date on which the uninstallation was detected</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_dteUninstallDetected"/>
    public virtual DateTime? dteUninstallDetected { get; set; }
    /// <summary>Uninstalled</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_dteUninstalled"/>
    public virtual DateTime? dteUninstalled { get; set; }
    /// <summary>Detection product language - LCID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_intDetLanguage"/>
    public virtual int? intDetLanguage { get; set; }
    /// <summary>installation id</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_intInstHistId"/>
    [Key]
    public virtual int intInstHistId { get; set; }
    /// <summary>Installed by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_liInstalledPersonId"/>
    public virtual int? liInstalledPersonId { get; set; }
    /// <summary>Uninstalled by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_liUninstalledPersonId"/>
    public virtual int? liUninstalledPersonId { get; set; }
    /// <summary>Computer - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>Which detection detected the installation - tblDetect</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_lintInstallDetectId"/>
    public virtual int? lintInstallDetectId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <summary>Which detection detected the uninstallation - tblDetect</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_lintUnistallDetectId"/>
    public virtual int? lintUnistallDetectId { get; set; }
    /// <summary>Detected CD-Key</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetCDKey"/>
    public virtual string txtDetCDKey { get; set; }
    /// <summary>Detected installation date</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetInstallDate"/>
    public virtual string txtDetInstallDate { get; set; }
    /// <summary>Detected Product-ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetProductId"/>
    public virtual string txtDetProductId { get; set; }
    /// <summary>Name of detected product</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetProductName"/>
    public virtual string txtDetProductName { get; set; }
    /// <summary>Version of detected product</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetProductVersion"/>
    public virtual string txtDetProductVersion { get; set; }
    /// <summary>Recognized by</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetRecognizedBy"/>
    public virtual string txtDetRecognizedBy { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtMemo"/>
    public virtual string txtMemo { get; set; }
}
