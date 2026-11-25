using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected registry entries. The table contains records which may repeat in various computers.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html"/>
[Table("dbo.tblRegUninstall")]
public class tblRegUninstall {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_EvalSwLibDate"/>
    /// <remarks>Column <c>EvalSwLibDate</c>: datetime, null.</remarks>
    public virtual DateTime? EvalSwLibDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_FullName"/>
    /// <remarks>Column <c>FullName</c>: nvarchar(511), not null.</remarks>
    [Computed]
    public virtual string FullName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_Hash"/>
    /// <remarks>Column <c>Hash</c>: varbinary, not null.</remarks>
    public virtual byte[] Hash { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intLanguage"/>
    /// <remarks>Column <c>intLanguage</c>: int, null.</remarks>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intRegUninstallId"/>
    /// <remarks>Column <c>intRegUninstallId</c>: int, not null.</remarks>
    [Key]
    public virtual int intRegUninstallId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intSystemComponent"/>
    /// <remarks>Column <c>intSystemComponent</c>: int, null.</remarks>
    public virtual int? intSystemComponent { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intVersion"/>
    /// <remarks>Column <c>intVersion</c>: int, null.</remarks>
    public virtual int? intVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intVersionMajor"/>
    /// <remarks>Column <c>intVersionMajor</c>: int, null.</remarks>
    public virtual int? intVersionMajor { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intVersionMinor"/>
    /// <remarks>Column <c>intVersionMinor</c>: int, null.</remarks>
    public virtual int? intVersionMinor { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_intWindowsInstaller"/>
    /// <remarks>Column <c>intWindowsInstaller</c>: int, null.</remarks>
    public virtual int? intWindowsInstaller { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_lintOriginalProductId"/>
    /// <remarks>Column <c>lintOriginalProductId</c>: int, null. References <see cref="tblProduct"/>.</remarks>
    public virtual int? lintOriginalProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_lintProductId"/>
    /// <remarks>Column <c>lintProductId</c>: int, null. References <see cref="tblProduct"/>.</remarks>
    public virtual int? lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_lintRegImageId"/>
    /// <remarks>Column <c>lintRegImageId</c>: int, null. References <see cref="tblRegImage"/>.</remarks>
    public virtual int? lintRegImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_lintRootRegKeyId"/>
    /// <remarks>Column <c>lintRootRegKeyId</c>: int, not null.</remarks>
    public virtual int lintRootRegKeyId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtAuthorizedCDFPrefix"/>
    /// <remarks>Column <c>txtAuthorizedCDFPrefix</c>: nvarchar(255), null.</remarks>
    public virtual string txtAuthorizedCDFPrefix { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtComments"/>
    /// <remarks>Column <c>txtComments</c>: nvarchar(255), null.</remarks>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtContact"/>
    /// <remarks>Column <c>txtContact</c>: nvarchar(255), null.</remarks>
    public virtual string txtContact { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtDisplayName"/>
    /// <remarks>Column <c>txtDisplayName</c>: nvarchar(255), null.</remarks>
    public virtual string txtDisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtDisplayVersion"/>
    /// <remarks>Column <c>txtDisplayVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtDisplayVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtHelpLink"/>
    /// <remarks>Column <c>txtHelpLink</c>: nvarchar(255), null.</remarks>
    public virtual string txtHelpLink { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtHelpTelephone"/>
    /// <remarks>Column <c>txtHelpTelephone</c>: nvarchar(255), null.</remarks>
    public virtual string txtHelpTelephone { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtPath"/>
    /// <remarks>Column <c>txtPath</c>: nvarchar(255), not null.</remarks>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtPublisher"/>
    /// <remarks>Column <c>txtPublisher</c>: nvarchar(255), null.</remarks>
    public virtual string txtPublisher { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtSize"/>
    /// <remarks>Column <c>txtSize</c>: nvarchar(255), null.</remarks>
    public virtual string txtSize { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtURLInfoAbout"/>
    /// <remarks>Column <c>txtURLInfoAbout</c>: nvarchar(255), null.</remarks>
    public virtual string txtURLInfoAbout { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegUninstall.html#Alvao_API_Common_Model_Database_tblRegUninstall_txtURLUpdateInfo"/>
    /// <remarks>Column <c>txtURLUpdateInfo</c>: nvarchar(255), null.</remarks>
    public virtual string txtURLUpdateInfo { get; set; }
}
