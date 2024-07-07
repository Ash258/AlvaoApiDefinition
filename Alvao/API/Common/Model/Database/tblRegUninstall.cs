using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected registry entries. The table contains records which may repeat in various computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblRegUninstall.htm"/>
[TableAttribute("dbo.tblRegUninstall")]
public class tblRegUninstall
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_EvalSwLibDate.htm"/>
    public virtual DateTime? EvalSwLibDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_FullName.htm"/>
    [ComputedAttribute]
    public virtual string FullName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_Hash.htm"/>
    public virtual byte[] Hash { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_intLanguage.htm"/>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_intRegUninstallId.htm"/>
    [KeyAttribute]
    public virtual int intRegUninstallId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_intSystemComponent.htm"/>
    public virtual int? intSystemComponent { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_intVersion.htm"/>
    public virtual int? intVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_intVersionMajor.htm"/>
    public virtual int? intVersionMajor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_intVersionMinor.htm"/>
    public virtual int? intVersionMinor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_intWindowsInstaller.htm"/>
    public virtual int? intWindowsInstaller { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_lintOriginalProductId.htm"/>
    public virtual int? lintOriginalProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_lintProductId.htm"/>
    public virtual int? lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_lintRegImageId.htm"/>
    public virtual int? lintRegImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_lintRootRegKeyId.htm"/>
    public virtual int lintRootRegKeyId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtAuthorizedCDFPrefix.htm"/>
    public virtual string txtAuthorizedCDFPrefix { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtComments.htm"/>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtContact.htm"/>
    public virtual string txtContact { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtDisplayName.htm"/>
    public virtual string txtDisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtDisplayVersion.htm"/>
    public virtual string txtDisplayVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtHelpLink.htm"/>
    public virtual string txtHelpLink { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtHelpTelephone.htm"/>
    public virtual string txtHelpTelephone { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtPath.htm"/>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtPublisher.htm"/>
    public virtual string txtPublisher { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtSize.htm"/>
    public virtual string txtSize { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtURLInfoAbout.htm"/>
    public virtual string txtURLInfoAbout { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegUninstall_txtURLUpdateInfo.htm"/>
    public virtual string txtURLUpdateInfo { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblRegUninstall__ctor.htm"/>
    public tblRegUninstall() { }
}
