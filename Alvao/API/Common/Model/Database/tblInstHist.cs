using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Records on installation and uninstallation of products on the computers (manual as well as detected)
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html"/>
[Table("dbo.tblInstHist")]
public class tblInstHist {
    /// <summary>Date of manual or detected installation of the product.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_Installed"/>
    /// <remarks>Column <c>Installed</c>: datetime, null.</remarks>
    public virtual DateTime? Installed { get; set; }
    /// <summary>Date of manual or detected uninstallation of the product.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_Uninstalled"/>
    /// <remarks>Column <c>Uninstalled</c>: datetime, null.</remarks>
    public virtual DateTime? Uninstalled { get; set; }
    /// <summary>Date on which the installation was detected</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_dteInstallDetected"/>
    /// <remarks>Column <c>dteInstallDetected</c>: datetime, null.</remarks>
    public virtual DateTime? dteInstallDetected { get; set; }
    /// <summary>Installed</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_dteInstalled"/>
    /// <remarks>Column <c>dteInstalled</c>: datetime, null.</remarks>
    public virtual DateTime? dteInstalled { get; set; }
    /// <summary>Date on which the uninstallation was detected</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_dteUninstallDetected"/>
    /// <remarks>Column <c>dteUninstallDetected</c>: datetime, null.</remarks>
    public virtual DateTime? dteUninstallDetected { get; set; }
    /// <summary>Uninstalled</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_dteUninstalled"/>
    /// <remarks>Column <c>dteUninstalled</c>: datetime, null.</remarks>
    public virtual DateTime? dteUninstalled { get; set; }
    /// <summary>Detection product language - LCID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_intDetLanguage"/>
    /// <remarks>Column <c>intDetLanguage</c>: int, null.</remarks>
    public virtual int? intDetLanguage { get; set; }
    /// <summary>installation id</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_intInstHistId"/>
    /// <remarks>Column <c>intInstHistId</c>: int, not null.</remarks>
    [Key]
    public virtual int intInstHistId { get; set; }
    /// <summary>Installed by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_liInstalledPersonId"/>
    /// <remarks>Column <c>liInstalledPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liInstalledPersonId { get; set; }
    /// <summary>Uninstalled by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_liUninstalledPersonId"/>
    /// <remarks>Column <c>liUninstalledPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liUninstalledPersonId { get; set; }
    /// <summary>Computer - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_lintComputerNodeId"/>
    /// <remarks>Column <c>lintComputerNodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>Which detection detected the installation - tblDetect</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_lintInstallDetectId"/>
    /// <remarks>Column <c>lintInstallDetectId</c>: int, null. References <see cref="tblDetect"/>.</remarks>
    public virtual int? lintInstallDetectId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_lintProductId"/>
    /// <remarks>Column <c>lintProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    public virtual int lintProductId { get; set; }
    /// <summary>Which detection detected the uninstallation - tblDetect</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_lintUnistallDetectId"/>
    /// <remarks>Column <c>lintUnistallDetectId</c>: int, null. References <see cref="tblDetect"/>.</remarks>
    public virtual int? lintUnistallDetectId { get; set; }
    /// <summary>Detected CD-Key</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetCDKey"/>
    /// <remarks>Column <c>txtDetCDKey</c>: nvarchar(255), null.</remarks>
    public virtual string txtDetCDKey { get; set; }
    /// <summary>Detected installation date</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetInstallDate"/>
    /// <remarks>Column <c>txtDetInstallDate</c>: nvarchar(255), null.</remarks>
    public virtual string txtDetInstallDate { get; set; }
    /// <summary>Detected Product-ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetProductId"/>
    /// <remarks>Column <c>txtDetProductId</c>: nvarchar(255), null.</remarks>
    public virtual string txtDetProductId { get; set; }
    /// <summary>Name of detected product</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetProductName"/>
    /// <remarks>Column <c>txtDetProductName</c>: nvarchar(255), null.</remarks>
    public virtual string txtDetProductName { get; set; }
    /// <summary>Version of detected product</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetProductVersion"/>
    /// <remarks>Column <c>txtDetProductVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtDetProductVersion { get; set; }
    /// <summary>Recognized by</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtDetRecognizedBy"/>
    /// <remarks>Column <c>txtDetRecognizedBy</c>: nvarchar(255), null.</remarks>
    public virtual string txtDetRecognizedBy { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstHist.html#Alvao_API_Common_Model_Database_tblInstHist_txtMemo"/>
    /// <remarks>Column <c>txtMemo</c>: nvarchar(max), null.</remarks>
    public virtual string txtMemo { get; set; }
}
