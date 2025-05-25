using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Stocktaking date.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryDate.html"/>
[Table("dbo.vPropertyKind_InventoryDate")]
public class vPropertyKind_InventoryDate {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryDate.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryDate.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryDate.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryDate.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryDate.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_txtValue"/>
    public virtual DateTime? txtValue { get; set; }
}
