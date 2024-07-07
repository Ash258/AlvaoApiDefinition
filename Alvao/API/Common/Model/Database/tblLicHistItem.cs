using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// License - license items.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblLicHistItem.htm"/>
[TableAttribute("dbo.tblLicHistItem")]
public class tblLicHistItem
{
    /// <summary>Serial number</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_ActivationKey.htm"/>
    public virtual string ActivationKey { get; set; }
    /// <summary>Automatically assigned item</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_AutoAssigned.htm"/>
    public virtual bool AutoAssigned { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_intLicHistItemId.htm"/>
    [KeyAttribute]
    public virtual int intLicHistItemId { get; set; }
    /// <summary>Number of assigned licenses</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_LicensesCount.htm"/>
    public virtual int LicensesCount { get; set; }
    /// <summary>License ID - tblLicHist</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_lintLicHistId.htm"/>
    public virtual int lintLicHistId { get; set; }
    /// <summary>Computer ID - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_NodeId.htm"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Center</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_txtDepartment.htm"/>
    public virtual string txtDepartment { get; set; }
    /// <summary>Inventory number</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_txtInventoryNum.htm"/>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }
    /// <summary>Ticket</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLicHistItem_txtRequest.htm"/>
    public virtual string txtRequest { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblLicHistItem__ctor.htm"/>
    public tblLicHistItem() { }
}
