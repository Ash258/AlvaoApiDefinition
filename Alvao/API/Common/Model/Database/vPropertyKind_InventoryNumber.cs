using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Properties of objects - Asset number.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber.htm"/>
[TableAttribute("dbo.vPropertyKind_InventoryNumber")]
public class vPropertyKind_InventoryNumber
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_bolInheritable.htm"/>
    public virtual bool bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_intNameOrder.htm"/>
    public virtual int? intNameOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_intPropertyId.htm"/>
    public virtual int intPropertyId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_intState.htm"/>
    public virtual int? intState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_lintKindId.htm"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_lintNodeId.htm"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_txtKind.htm"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber_txtValue.htm"/>
    public virtual string txtValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vPropertyKind_InventoryNumber__ctor.htm"/>
    public vPropertyKind_InventoryNumber() { }
}
