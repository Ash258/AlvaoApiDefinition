using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicHistBase.htm"/>
[TableAttribute("dbo.vLicHistBase")]
public class vLicHistBase {
    /// <summary>License downgrade.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_bolDowngrade.htm"/>
    public virtual int bolDowngrade { get; set; }
    /// <summary>Date of license purchase.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_dteDate.htm"/>
    public virtual DateTime dteDate { get; set; }
    /// <summary>License Expiration Date.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_dteDateExpire.htm"/>
    public virtual DateTime? dteDateExpire { get; set; }
    /// <summary>Current number of allocated licenses.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_intAssignedCount.htm"/>
    public virtual int? intAssignedCount { get; set; }
    /// <summary>Current number of licenses.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_intCurrentCount.htm"/>
    public virtual int? intCurrentCount { get; set; }
    /// <summary>License ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_intLicHistId.htm"/>
    public virtual int intLicHistId { get; set; }
    /// <summary>Number of licenses purchased.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_LicenseCount.htm"/>
    public virtual int? LicenseCount { get; set; }
    /// <summary>Activation key.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtActivationKey.htm"/>
    public virtual string txtActivationKey { get; set; }
    /// <summary>Inventory number.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtInventoryNum.htm"/>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>The name of the document assigned to the license - vDocument.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtInvoice.htm"/>
    public virtual string txtInvoice { get; set; }
    /// <summary>Product language - vLang.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtLang.htm"/>
    public virtual string txtLang { get; set; }
    /// <summary>License name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtLicName.htm"/>
    public virtual string txtLicName { get; set; }
    /// <summary>License type.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtLicType.htm"/>
    public virtual string txtLicType { get; set; }
    /// <summary>Note.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }
    /// <summary>Product name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtProductName.htm"/>
    public virtual string txtProductName { get; set; }
    /// <summary>Product type.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtProductType.htm"/>
    public virtual string txtProductType { get; set; }
    /// <summary>Supplier name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistBase_txtResellerCompany.htm"/>
    public virtual string txtResellerCompany { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vLicHistBase__ctor.htm"/>
    public vLicHistBase() { }
}
