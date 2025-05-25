using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html"/>
[Table("dbo.vLicHistBase")]
public class vLicHistBase {
    /// <summary>Number of licenses purchased.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_LicenseCount"/>
    public virtual int? LicenseCount { get; set; }
    /// <summary>License downgrade.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_bolDowngrade"/>
    public virtual int bolDowngrade { get; set; }
    /// <summary>Date of license purchase.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_dteDate"/>
    public virtual DateTime dteDate { get; set; }
    /// <summary>License Expiration Date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_dteDateExpire"/>
    public virtual DateTime? dteDateExpire { get; set; }
    /// <summary>Current number of allocated licenses.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_intAssignedCount"/>
    public virtual int? intAssignedCount { get; set; }
    /// <summary>Current number of licenses.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_intCurrentCount"/>
    public virtual int? intCurrentCount { get; set; }
    /// <summary>License ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_intLicHistId"/>
    public virtual int intLicHistId { get; set; }
    /// <summary>Activation key.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtActivationKey"/>
    public virtual string txtActivationKey { get; set; }
    /// <summary>Inventory number.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtInventoryNum"/>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>The name of the document assigned to the license - vDocument.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtInvoice"/>
    public virtual string txtInvoice { get; set; }
    /// <summary>Product language - vLang.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtLang"/>
    public virtual string txtLang { get; set; }
    /// <summary>License name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtLicName"/>
    public virtual string txtLicName { get; set; }
    /// <summary>License type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtLicType"/>
    public virtual string txtLicType { get; set; }
    /// <summary>Note.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtMemo"/>
    public virtual string txtMemo { get; set; }
    /// <summary>Product name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtProductName"/>
    public virtual string txtProductName { get; set; }
    /// <summary>Product type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtProductType"/>
    public virtual string txtProductType { get; set; }
    /// <summary>Supplier name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistBase.html#Alvao_API_Common_Model_Database_vLicHistBase_txtResellerCompany"/>
    public virtual string txtResellerCompany { get; set; }
}
