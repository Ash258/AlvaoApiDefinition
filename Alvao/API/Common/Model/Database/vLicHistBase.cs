using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// License.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicHistBase.htm"/>
[TableAttribute("dbo.vLicHistBase")]
public class vLicHistBase
{
    /// <summary>License downgrade.</summary>
    public virtual int bolDowngrade { get; set; }
    /// <summary>Date of license purchase.</summary>
    public virtual DateTime dteDate { get; set; }
    /// <summary>License Expiration Date.</summary>
    public virtual DateTime? dteDateExpire { get; set; }
    /// <summary>Current number of allocated licenses.</summary>
    public virtual int? intAssignedCount { get; set; }
    /// <summary>Current number of licenses.</summary>
    public virtual int? intCurrentCount { get; set; }
    /// <summary>License ID.</summary>
    public virtual int intLicHistId { get; set; }
    /// <summary>Number of licenses purchased.</summary>
    public virtual int? LicenseCount { get; set; }
    /// <summary>Activation key.</summary>
    public virtual string txtActivationKey { get; set; }
    /// <summary>Inventory number.</summary>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>The name of the document assigned to the license - vDocument.</summary>
    public virtual string txtInvoice { get; set; }
    /// <summary>Product language - vLang.</summary>
    public virtual string txtLang { get; set; }
    /// <summary>License name.</summary>
    public virtual string txtLicName { get; set; }
    /// <summary>License type.</summary>
    public virtual string txtLicType { get; set; }
    /// <summary>Note.</summary>
    public virtual string txtMemo { get; set; }
    /// <summary>Product name.</summary>
    public virtual string txtProductName { get; set; }
    /// <summary>Product type.</summary>
    public virtual string txtProductType { get; set; }
    /// <summary>Supplier name.</summary>
    public virtual string txtResellerCompany { get; set; }

    public vLicHistBase() { }
}
