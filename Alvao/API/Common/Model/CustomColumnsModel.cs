namespace Alvao.API.Common.Model;

/// <summary>Custom columns model</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_CustomColumnsModel.htm"/>
public class CustomColumnsModel
{
    /// <summary>Column values to update.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_CustomColumnsModel_ColumnValues.htm"/>
    public IEnumerable<ColumnValue> ColumnValues { get; set; }
    /// <summary>Custom table name, use consts from Alvao.API.Common.Model.CustomTables.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_CustomColumnsModel_CustomTableName.htm"/>
    public string CustomTableName { get; set; }
    /// <summary>Custom table entity identificator (eg. tHdTicket.iHdTicketId for tHdTicketCust, tPerson.iPersonId for tPersonCust).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_CustomColumnsModel_EntityId.htm"/>
    public int EntityId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_CustomColumnsModel__ctor.htm"/>
    public CustomColumnsModel() { }
}
