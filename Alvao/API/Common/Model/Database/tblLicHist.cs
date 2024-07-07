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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_AutoAssign.htm"/>
    public virtual bool AutoAssign { get; set; }
    /// <summary>Filter for automatic assignment of licenses.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_AutoAssignFilter.htm"/>
    public virtual string AutoAssignFilter { get; set; }
    /// <summary>A tag indicating whether the license should be automatically and immediately assigned.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_AutoAssignNow.htm"/>
    public virtual bool AutoAssignNow { get; set; }
    /// <summary>Cover package components when package itself is not installed. 0 = the license will cover the components of the package only if the license package itself is installed. 1 = the license covers the components of the package even if the package itself is not installed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_CoverPackPartsWithoutPackageInstalled.htm"/>
    public virtual bool CoverPackPartsWithoutPackageInstalled { get; set; }
    /// <summary>Created.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_CreatedDate.htm"/>
    public virtual DateTime? CreatedDate { get; set; }
    /// <summary>Author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_CreatedPersonId.htm"/>
    public virtual int? CreatedPersonId { get; set; }
    /// <summary>Purchase date</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_dteDate.htm"/>
    public virtual DateTime dteDate { get; set; }
    /// <summary>Date of expiration</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_dteDateExpire.htm"/>
    public virtual DateTime? dteDateExpire { get; set; }
    /// <summary>Date of upgrading to ...</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_dteUpgradeTo.htm"/>
    public virtual DateTime? dteUpgradeTo { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_intLicHistId.htm"/>
    [KeyAttribute]
    public virtual int intLicHistId { get; set; }
    /// <summary>The person who has invalidated the license.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_InvalidatedByPersonId.htm"/>
    public virtual int? InvalidatedByPersonId { get; set; }
    /// <summary>The date on which the license was invalidated.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_InvalidatedDate.htm"/>
    public virtual DateTime? InvalidatedDate { get; set; }
    /// <summary>A flag indicating whether the license is valid.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_IsValid.htm"/>
    [ComputedAttribute]
    public virtual bool IsValid { get; set; }
    /// <summary>Number of purchased licenses</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_LicenseCount.htm"/>
    public virtual int? LicenseCount { get; set; }
    /// <summary>1 = devices2 = user3 = connection4 = processor</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_LicKindId.htm"/>
    public virtual int LicKindId { get; set; }
    /// <summary>License type.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_LicTypeId.htm"/>
    public virtual int? LicTypeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }
    /// <summary>A flag indicating whether multiple license items can be assigned to the same object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_MultiAssign.htm"/>
    public virtual bool MultiAssign { get; set; }
    /// <summary>Check whether the assigned license covers any installations on endpoint devices or not (SaaS, CAL).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_NoProductInstallation.htm"/>
    public virtual bool NoProductInstallation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_Organization.htm"/>
    public string Organization { get; set; }
    /// <summary>Organization ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_OrganizationNodeId.htm"/>
    public virtual int? OrganizationNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_Product.htm"/>
    public string Product { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_ProductNotes.htm"/>
    public virtual string ProductNotes { get; set; }
    /// <summary>Activation key</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_txtActivationKey.htm"/>
    public virtual string txtActivationKey { get; set; }
    /// <summary>Cost center</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_txtDepartment.htm"/>
    public virtual string txtDepartment { get; set; }
    /// <summary>Inventory number</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_txtInventoryNum.htm"/>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>License name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_txtLicName.htm"/>
    public virtual string txtLicName { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }
    /// <summary>Unique license identifier in the external system.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHist_UId.htm"/>
    public virtual string UId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblLicHist__ctor.htm"/>
    public tblLicHist() { }
}
