using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Object properties - Serial number, Inventory number a Asset number.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyKind_Asset.htm"/>
[TableAttribute("dbo.vPropertyKind_Asset")]
public class vPropertyKind_Asset
{
    public virtual string EvidentiaryNumber { get; set; }
    public virtual int intNodeId { get; set; }
    public virtual string InventoryNumber { get; set; }
    public virtual string SerialNumber { get; set; }

    public vPropertyKind_Asset() { }
}
