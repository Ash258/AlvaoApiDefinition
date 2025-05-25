using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object properties - Serial number, Inventory number a Asset number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Asset.html"/>
[Table("dbo.vPropertyKind_Asset")]
public class vPropertyKind_Asset {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Asset.html#Alvao_API_Common_Model_Database_vPropertyKind_Asset_EvidentiaryNumber"/>
    public virtual string EvidentiaryNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Asset.html#Alvao_API_Common_Model_Database_vPropertyKind_Asset_InventoryNumber"/>
    public virtual string InventoryNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Asset.html#Alvao_API_Common_Model_Database_vPropertyKind_Asset_SerialNumber"/>
    public virtual string SerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Asset.html#Alvao_API_Common_Model_Database_vPropertyKind_Asset_intNodeId"/>
    public virtual int intNodeId { get; set; }
}
