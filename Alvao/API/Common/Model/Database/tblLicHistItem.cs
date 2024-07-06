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
    public virtual string ActivationKey { get; set; }
    /// <summary>Automatically assigned item</summary>
    public virtual bool AutoAssigned { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int intLicHistItemId { get; set; }
    /// <summary>Number of assigned licenses</summary>
    public virtual int LicensesCount { get; set; }
    /// <summary>License ID - tblLicHist</summary>
    public virtual int lintLicHistId { get; set; }
    /// <summary>Computer ID - tblNode</summary>
    public virtual int? NodeId { get; set; }
    /// <summary>Center</summary>
    public virtual string txtDepartment { get; set; }
    /// <summary>Inventory number</summary>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>Note</summary>
    public virtual string txtMemo { get; set; }
    /// <summary>Ticket</summary>
    public virtual string txtRequest { get; set; }

    public tblLicHistItem() { }
}
