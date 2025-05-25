using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected registry entries. The table contains records which may repeat in various computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html"/>
[Table("dbo.tblRegUninstall")]
public class tblRegUninstall {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_EvalSwLibDate"/>
    public virtual DateTime? EvalSwLibDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_FullName"/>
    [Computed]
    public virtual string FullName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_Hash"/>
    public virtual byte[] Hash { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intLanguage"/>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intRegUninstallId"/>
    [Key]
    public virtual int intRegUninstallId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intSystemComponent"/>
    public virtual int? intSystemComponent { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intVersion"/>
    public virtual int? intVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intVersionMajor"/>
    public virtual int? intVersionMajor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intVersionMinor"/>
    public virtual int? intVersionMinor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intWindowsInstaller"/>
    public virtual int? intWindowsInstaller { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_lintOriginalProductId"/>
    public virtual int? lintOriginalProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_lintProductId"/>
    public virtual int? lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_lintRegImageId"/>
    public virtual int? lintRegImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_lintRootRegKeyId"/>
    public virtual int lintRootRegKeyId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtAuthorizedCDFPrefix"/>
    public virtual string txtAuthorizedCDFPrefix { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtComments"/>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtContact"/>
    public virtual string txtContact { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtDisplayName"/>
    public virtual string txtDisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtDisplayVersion"/>
    public virtual string txtDisplayVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtHelpLink"/>
    public virtual string txtHelpLink { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtHelpTelephone"/>
    public virtual string txtHelpTelephone { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtPath"/>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtPublisher"/>
    public virtual string txtPublisher { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtSize"/>
    public virtual string txtSize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtURLInfoAbout"/>
    public virtual string txtURLInfoAbout { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtURLUpdateInfo"/>
    public virtual string txtURLUpdateInfo { get; set; }
}
