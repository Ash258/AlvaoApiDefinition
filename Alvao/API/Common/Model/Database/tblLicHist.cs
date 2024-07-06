using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// License - list of purchased software licenses.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblLicHist.htm"/>
[TableAttribute("dbo.tblLicHist")]
public class tblLicHist
{
    public enum LicenseKind
    {
        perDevice = 1,
        perUser = 2,
        perConnection = 3,
        perProcessor = 4,
        perCore = 5,
    }

    public enum LicenseType
    {
        Normal = 1,
        UnlimitedVolumeLicense = 2,
        Floating = 3,
        OEM = 4,
        CAL = 5,
    }


    /// <summary>Assign automatically</summary>
    public virtual bool AutoAssign { get; set; }
    /// <summary>Filter for automatic assignment of licenses.</summary>
    public virtual string AutoAssignFilter { get; set; }
    /// <summary>A tag indicating whether the license should be automatically and immediately assigned.</summary>
    public virtual bool AutoAssignNow { get; set; }
    /// <summary>Cover package components when package itself is not installed. 0 = the license will cover the components of the package only if the license package itself is installed. 1 = the license covers the components of the package even if the package itself is not installed.</summary>
    public virtual bool CoverPackPartsWithoutPackageInstalled { get; set; }
    /// <summary>Created.</summary>
    public virtual DateTime? CreatedDate { get; set; }
    /// <summary>Author - tPerson</summary>
    public virtual int? CreatedPersonId { get; set; }
    /// <summary>Purchase date</summary>
    public virtual DateTime dteDate { get; set; }
    /// <summary>Date of expiration</summary>
    public virtual DateTime? dteDateExpire { get; set; }
    /// <summary>Date of upgrading to ...</summary>
    public virtual DateTime? dteUpgradeTo { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int intLicHistId { get; set; }
    /// <summary>The person who has invalidated the license.</summary>
    public virtual int? InvalidatedByPersonId { get; set; }
    /// <summary>The date on which the license was invalidated.</summary>
    public virtual DateTime? InvalidatedDate { get; set; }
    /// <summary>A flag indicating whether the license is valid.</summary>
    [ComputedAttribute]
    public virtual bool IsValid { get; set; }
    /// <summary>Number of purchased licenses</summary>
    public virtual int? LicenseCount { get; set; }
    /// <summary>1 = devices2 = user3 = connection4 = processor</summary>
    public virtual int LicKindId { get; set; }
    /// <summary>License type.</summary>
    public virtual int? LicTypeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    public virtual int lintProductId { get; set; }
    /// <summary>A flag indicating whether multiple license items can be assigned to the same object.</summary>
    public virtual bool MultiAssign { get; set; }
    /// <summary>Check whether the assigned license covers any installations on endpoint devices or not (SaaS, CAL).</summary>
    public virtual bool NoProductInstallation { get; set; }
    public string Organization { get; set; }
    /// <summary>Organization ID.</summary>
    public virtual int? OrganizationNodeId { get; set; }
    public string Product { get; set; }
    public virtual string ProductNotes { get; set; }
    /// <summary>Activation key</summary>
    public virtual string txtActivationKey { get; set; }
    /// <summary>Cost center</summary>
    public virtual string txtDepartment { get; set; }
    /// <summary>Inventory number</summary>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>License name</summary>
    public virtual string txtLicName { get; set; }
    /// <summary>Note</summary>
    public virtual string txtMemo { get; set; }
    /// <summary>Unique license identifier in the external system.</summary>
    public virtual string UId { get; set; }

    public tblLicHist() { }
}
