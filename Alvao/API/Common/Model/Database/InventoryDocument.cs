using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Stocktaking - documents.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_InventoryDocument.htm"/>
[TableAttribute("dbo.InventoryDocument")]
public class InventoryDocument {
    /// <summary>Document (tblDocument.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_InventoryDocument_AMDocumentId.htm"/>
    public virtual int AMDocumentId { get; set; }
    /// <summary>Inventory (tblInventory.intInventoryId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_InventoryDocument_InventoryId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int InventoryId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_InventoryDocument__ctor.htm"/>
    public InventoryDocument() { }
}
