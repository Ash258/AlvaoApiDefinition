using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Installed software - valid products and outside system objects.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html"/>
[Table("dbo.vSwInst")]
public class vSwInst {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_dteInstallDetected"/>
    public virtual DateTime? dteInstallDetected { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_dteInstalled"/>
    public virtual DateTime? dteInstalled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_dteUninstallDetected"/>
    public virtual DateTime? dteUninstallDetected { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_dteUninstalled"/>
    public virtual DateTime? dteUninstalled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_intDetLanguage"/>
    public virtual int? intDetLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_intInstHistId"/>
    public virtual int intInstHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_liInstalledPersonId"/>
    public virtual int? liInstalledPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_liUninstalledPersonId"/>
    public virtual int? liUninstalledPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_lintInstallDetectId"/>
    public virtual int? lintInstallDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_lintUnistallDetectId"/>
    public virtual int? lintUnistallDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_txtDetCDKey"/>
    public virtual string txtDetCDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_txtDetInstallDate"/>
    public virtual string txtDetInstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_txtDetProductId"/>
    public virtual string txtDetProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_txtDetProductName"/>
    public virtual string txtDetProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_txtDetProductVersion"/>
    public virtual string txtDetProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_txtDetRecognizedBy"/>
    public virtual string txtDetRecognizedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst.html#Alvao_API_Common_Model_Database_vSwInst_txtMemo"/>
    public virtual string txtMemo { get; set; }
}
