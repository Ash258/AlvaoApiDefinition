using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Stocktaking - list of stocktakings.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInventory.htm"/>
[TableAttribute("dbo.tblInventory")]
public class tblInventory
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventory_bolSelectionLocked.htm"/>
    public virtual bool bolSelectionLocked { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventory_dteClosed.htm"/>
    public virtual DateTime? dteClosed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventory_dteCreated.htm"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventory_intInventoryId.htm"/>
    [KeyAttribute]
    public virtual int intInventoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventory_txtDesc.htm"/>
    public virtual string txtDesc { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblInventory__ctor.htm"/>
    public tblInventory() { }
}
