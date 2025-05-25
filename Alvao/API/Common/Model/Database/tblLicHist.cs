using AutoMapper.Configuration.Annotations;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - list of purchased software licenses.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html"/>
[Table("dbo.tblLicHist")]
public class tblLicHist {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.LicenseKind.html#fields"/>
    public enum LicenseKind {
        perConnection = 3,
        perCore = 5,
        perDevice = 1,
        perProcessor = 4,
        perUser = 2,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.LicenseType.html#fields"/>
    public enum LicenseType {
        CAL = 5,
        Floating = 3,
        Normal = 1,
        OEM = 4,
        UnlimitedVolumeLicense = 2,
    }
    /// <summary>Assign automatically</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_AutoAssign"/>
    public virtual bool AutoAssign { get; set; }
    /// <summary>Filter for automatic assignment of licenses.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_AutoAssignFilter"/>
    public virtual string AutoAssignFilter { get; set; }
    /// <summary>A tag indicating whether the license should be automatically and immediately assigned.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_AutoAssignNow"/>
    public virtual bool AutoAssignNow { get; set; }
    /// <summary>Cover package components when package itself is not installed. 0 = the license will cover the components of the package only if the license package itself is installed. 1 = the license covers the components of the package even if the package itself is not installed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_CoverPackPartsWithoutPackageInstalled"/>
    public virtual bool CoverPackPartsWithoutPackageInstalled { get; set; }
    /// <summary>Created.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_CreatedDate"/>
    public virtual DateTime? CreatedDate { get; set; }
    /// <summary>Author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_CreatedPersonId"/>
    public virtual int? CreatedPersonId { get; set; }
    /// <summary>The person who has invalidated the license.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_InvalidatedByPersonId"/>
    public virtual int? InvalidatedByPersonId { get; set; }
    /// <summary>The date on which the license was invalidated.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_InvalidatedDate"/>
    public virtual DateTime? InvalidatedDate { get; set; }
    /// <summary>A flag indicating whether the license is valid.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_IsValid"/>
    [Computed]
    public virtual bool IsValid { get; set; }
    /// <summary>1 = devices 2 = user 3 = connection 4 = processor</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_LicKindId"/>
    public virtual int LicKindId { get; set; }
    /// <summary>License type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_LicTypeId"/>
    public virtual int? LicTypeId { get; set; }
    /// <summary>Number of purchased licenses</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_LicenseCount"/>
    public virtual int? LicenseCount { get; set; }
    /// <summary>A flag indicating whether multiple license items can be assigned to the same object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_MultiAssign"/>
    public virtual bool MultiAssign { get; set; }
    /// <summary>Check whether the assigned license covers any installations on endpoint devices or not (SaaS, CAL).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_NoProductInstallation"/>
    public virtual bool NoProductInstallation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_Organization"/>
    [Ignore]
    public string Organization { get; set; }
    /// <summary>Organization ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_OrganizationNodeId"/>
    public virtual int? OrganizationNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_Product"/>
    [Ignore]
    public string Product { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_ProductNotes"/>
    public virtual string ProductNotes { get; set; }
    /// <summary>Unique license identifier in the external system.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_UId"/>
    public virtual string UId { get; set; }
    /// <summary>Purchase date</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_dteDate"/>
    public virtual DateTime dteDate { get; set; }
    /// <summary>Date of expiration</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_dteDateExpire"/>
    public virtual DateTime? dteDateExpire { get; set; }
    /// <summary>Date of upgrading to ...</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_dteUpgradeTo"/>
    public virtual DateTime? dteUpgradeTo { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_intLicHistId"/>
    [Key]
    public virtual int intLicHistId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <summary>Activation key</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtActivationKey"/>
    public virtual string txtActivationKey { get; set; }
    /// <summary>Cost center</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtDepartment"/>
    public virtual string txtDepartment { get; set; }
    /// <summary>Inventory number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtInventoryNum"/>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>License name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtLicName"/>
    public virtual string txtLicName { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHist.html#Alvao_API_Common_Model_Database_tblLicHist_txtMemo"/>
    public virtual string txtMemo { get; set; }
}
