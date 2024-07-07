using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Installed software - valid products and outside system objects.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInst.htm"/>
[TableAttribute("dbo.vSwInst")]
public class vSwInst
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_dteInstallDetected.htm"/>
    public virtual DateTime? dteInstallDetected { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_dteInstalled.htm"/>
    public virtual DateTime? dteInstalled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_dteUninstallDetected.htm"/>
    public virtual DateTime? dteUninstallDetected { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_dteUninstalled.htm"/>
    public virtual DateTime? dteUninstalled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_intDetLanguage.htm"/>
    public virtual int? intDetLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_intInstHistId.htm"/>
    public virtual int intInstHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_liInstalledPersonId.htm"/>
    public virtual int? liInstalledPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_lintInstallDetectId.htm"/>
    public virtual int? lintInstallDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_lintUnistallDetectId.htm"/>
    public virtual int? lintUnistallDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_liUninstalledPersonId.htm"/>
    public virtual int? liUninstalledPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_txtDetCDKey.htm"/>
    public virtual string txtDetCDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_txtDetInstallDate.htm"/>
    public virtual string txtDetInstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_txtDetProductId.htm"/>
    public virtual string txtDetProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_txtDetProductName.htm"/>
    public virtual string txtDetProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_txtDetProductVersion.htm"/>
    public virtual string txtDetProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_txtDetRecognizedBy.htm"/>
    public virtual string txtDetRecognizedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSwInst__ctor.htm"/>
    public vSwInst() { }
}
