namespace Alvao.API.Common.Model;

/// <summary>
/// Custom columns model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_CustomColumnsModel.htm"/>
public class CustomColumnsModel
{
    /// <summary>Column values to update.</summary>
    public IEnumerable<ColumnValue> ColumnValues { get; set; }
    /// <summary>Custom table name, use consts from Alvao.API.Common.Model.CustomTables.</summary>
    public string CustomTableName { get; set; }
    /// <summary>Custom table entity identificator (eg. tHdTicket.iHdTicketId for tHdTicketCust, tPerson.iPersonId for tPersonCust).</summary>
    public int EntityId { get; set; }

    public CustomColumnsModel() { }
}
