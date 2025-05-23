using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Stocktaking date.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate.htm"/>
[TableAttribute("dbo.vPropertyKind_InventoryDate")]
public class vPropertyKind_InventoryDate {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_bolInheritable.htm"/>
    public virtual bool bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_intNameOrder.htm"/>
    public virtual int? intNameOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_intPropertyId.htm"/>
    public virtual int intPropertyId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_intState.htm"/>
    public virtual int? intState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_lintKindId.htm"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_lintNodeId.htm"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_txtKind.htm"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate_txtValue.htm"/>
    public virtual string txtValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vPropertyKind_InventoryDate__ctor.htm"/>
    public vPropertyKind_InventoryDate() { }
}
