using AutoMapper.Configuration.Annotations;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - list of purchased software licenses.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html"/>
[Table("dbo.tblLicHist")]
public class tblLicHist {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.LicenseKind.html#fields"/>
    public enum LicenseKind {
        perDevice = 1,
        perUser = 2,
        perConnection = 3,
        perProcessor = 4,
        perCore = 5,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.LicenseType.html#fields"/>
    public enum LicenseType {
        Normal = 1,
        UnlimitedVolumeLicense = 2,
        Floating = 3,
        OEM = 4,
        CAL = 5,
    }

    /// <summary>Assign automatically</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_AutoAssign"/>
    /// <remarks>Column <c>AutoAssign</c>: bit, not null.</remarks>
    public virtual bool AutoAssign { get; set; }
    /// <summary>Filter for automatic assignment of licenses.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_AutoAssignFilter"/>
    /// <remarks>Column <c>AutoAssignFilter</c>: nvarchar(max), null.</remarks>
    public virtual string AutoAssignFilter { get; set; }
    /// <summary>A tag indicating whether the license should be automatically and immediately assigned.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_AutoAssignNow"/>
    /// <remarks>Column <c>AutoAssignNow</c>: bit, not null.</remarks>
    public virtual bool AutoAssignNow { get; set; }
    /// <summary>
    /// Cover package components when package itself is not installed. 0 = the license will cover the components of the
    /// package only if the license package itself is installed. 1 = the license covers the components of the package
    /// even if the package itself is not installed.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_CoverPackPartsWithoutPackageInstalled"/>
    /// <remarks>Column <c>CoverPackPartsWithoutPackageInstalled</c>: bit, not null.</remarks>
    public virtual bool CoverPackPartsWithoutPackageInstalled { get; set; }
    /// <summary>Created.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_CreatedDate"/>
    /// <remarks>Column <c>CreatedDate</c>: datetime, null.</remarks>
    public virtual DateTime? CreatedDate { get; set; }
    /// <summary>Author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_CreatedPersonId"/>
    /// <remarks>Column <c>CreatedPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? CreatedPersonId { get; set; }
    /// <summary>The person who has invalidated the license.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_InvalidatedByPersonId"/>
    /// <remarks>Column <c>InvalidatedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? InvalidatedByPersonId { get; set; }
    /// <summary>The date on which the license was invalidated.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_InvalidatedDate"/>
    /// <remarks>Column <c>InvalidatedDate</c>: datetime, null.</remarks>
    public virtual DateTime? InvalidatedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <summary>A flag indicating whether the license is valid.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_IsValid"/>
    /// <remarks>Column <c>IsValid</c>: bit, not null.</remarks>
    [Computed]
    public virtual bool IsValid { get; set; }
    /// <summary>1 = devices 2 = user 3 = connection 4 = processor</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_LicKindId"/>
    /// <remarks>Column <c>LicKindId</c>: int, not null. References <see cref="LicKind"/>.</remarks>
    public virtual int LicKindId { get; set; }
    /// <summary>License type.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_LicTypeId"/>
    /// <remarks>Column <c>LicTypeId</c>: int, null. References <see cref="LicType"/>.</remarks>
    public virtual int? LicTypeId { get; set; }
    /// <summary>Number of purchased licenses</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_LicenseCount"/>
    /// <remarks>Column <c>LicenseCount</c>: int, null.</remarks>
    public virtual int? LicenseCount { get; set; }
    /// <summary>A flag indicating whether multiple license items can be assigned to the same object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_MultiAssign"/>
    /// <remarks>Column <c>MultiAssign</c>: bit, not null.</remarks>
    public virtual bool MultiAssign { get; set; }
    /// <summary>
    /// Check whether the assigned license covers any installations on endpoint devices or not (SaaS, CAL).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_NoProductInstallation"/>
    /// <remarks>Column <c>NoProductInstallation</c>: bit, not null.</remarks>
    public virtual bool NoProductInstallation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_Organization"/>
    [Ignore]
    public string Organization { get; set; }
    /// <summary>Organization ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_OrganizationNodeId"/>
    /// <remarks>Column <c>OrganizationNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? OrganizationNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_Product"/>
    [Ignore]
    public string Product { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_ProductNotes"/>
    /// <remarks>Column <c>ProductNotes</c>: nvarchar(255), null.</remarks>
    public virtual string ProductNotes { get; set; }
    /// <summary>Unique license identifier in the external system.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_UId"/>
    /// <remarks>Column <c>UId</c>: nvarchar(255), null.</remarks>
    public virtual string UId { get; set; }
    /// <summary>Purchase date</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_dteDate"/>
    /// <remarks>Column <c>dteDate</c>: date, not null.</remarks>
    public virtual DateTime dteDate { get; set; }
    /// <summary>Date of expiration</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_dteDateExpire"/>
    /// <remarks>Column <c>dteDateExpire</c>: date, null.</remarks>
    public virtual DateTime? dteDateExpire { get; set; }
    /// <summary>Date of upgrading to ...</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_dteUpgradeTo"/>
    /// <remarks>Column <c>dteUpgradeTo</c>: date, null.</remarks>
    public virtual DateTime? dteUpgradeTo { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_intLicHistId"/>
    /// <remarks>Column <c>intLicHistId</c>: int, not null.</remarks>
    [Key]
    public virtual int intLicHistId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_lintProductId"/>
    /// <remarks>Column <c>lintProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    public virtual int lintProductId { get; set; }
    /// <summary>Activation key</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtActivationKey"/>
    /// <remarks>Column <c>txtActivationKey</c>: nvarchar(1024), null.</remarks>
    public virtual string txtActivationKey { get; set; }
    /// <summary>Cost center</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtDepartment"/>
    /// <remarks>Column <c>txtDepartment</c>: nvarchar(255), null.</remarks>
    public virtual string txtDepartment { get; set; }
    /// <summary>Inventory number</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtInventoryNum"/>
    /// <remarks>Column <c>txtInventoryNum</c>: nvarchar(255), null.</remarks>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>License name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtLicName"/>
    /// <remarks>Column <c>txtLicName</c>: nvarchar(255), null.</remarks>
    public virtual string txtLicName { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtMemo"/>
    /// <remarks>Column <c>txtMemo</c>: nvarchar(max), null.</remarks>
    public virtual string txtMemo { get; set; }
}
