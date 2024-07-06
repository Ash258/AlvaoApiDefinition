using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Stocktaking - documents.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_InventoryDocument.htm"/>
[TableAttribute("dbo.InventoryDocument")]
public class InventoryDocument
{
    /// <summary>Document (tblDocument.id)</summary>
    public virtual int AMDocumentId { get; set; }
    /// <summary>Inventory (tblInventory.intInventoryId).</summary>
    [ExplicitKeyAttribute]
    public virtual int InventoryId { get; set; }

    public InventoryDocument() { }
}
