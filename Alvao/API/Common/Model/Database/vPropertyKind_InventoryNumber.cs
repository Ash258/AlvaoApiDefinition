using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Asset number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryNumber.html"/>
[Table("dbo.vPropertyKind_InventoryNumber")]
public class vPropertyKind_InventoryNumber {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InventoryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_txtValue"/>
    public virtual string txtValue { get; set; }
}
