using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License items.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html"/>
[Table("dbo.vLicHistItem")]
public class vLicHistItem {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_ActivationKey"/>
    public virtual string ActivationKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_LicensesCount"/>
    public virtual int LicensesCount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_NodeId"/>
    public virtual int? NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_Object"/>
    public virtual string Object { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_bolOEM"/>
    public virtual int bolOEM { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_intLicHistItemId"/>
    public virtual int intLicHistItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_lintLicHistId"/>
    public virtual int lintLicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_txtDepartment"/>
    public virtual string txtDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_txtInventoryNum"/>
    public virtual string txtInventoryNum { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_txtMemo"/>
    public virtual string txtMemo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistItem.html#Alvao_API_Common_Model_Database_vLicHistItem_txtRequest"/>
    public virtual string txtRequest { get; set; }
}
