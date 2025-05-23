using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License items.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicHistItem.htm"/>
[TableAttribute("dbo.vLicHistItem")]
public class vLicHistItem {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_ActivationKey.htm"/>
    public virtual string ActivationKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_bolOEM.htm"/>
    public virtual int bolOEM { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_intLicHistItemId.htm"/>
    public virtual int intLicHistItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_LicensesCount.htm"/>
    public virtual int LicensesCount { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_lintLicHistId.htm"/>
    public virtual int lintLicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_NodeId.htm"/>
    public virtual int? NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_Object.htm"/>
    public virtual string Object { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_txtDepartment.htm"/>
    public virtual string txtDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_txtInventoryNum.htm"/>
    public virtual string txtInventoryNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistItem_txtRequest.htm"/>
    public virtual string txtRequest { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vLicHistItem__ctor.htm"/>
    public vLicHistItem() { }
}
