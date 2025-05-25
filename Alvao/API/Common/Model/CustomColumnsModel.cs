namespace Alvao.API.Common.Model;

/// <summary>Custom columns model</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomColumnsModel.html"/>
public class CustomColumnsModel {
    /// <summary>Column values to update.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomColumnsModel.html#Alvao_API_Common_Model_CustomColumnsModel_ColumnValues"/>
    public IEnumerable<ColumnValue> ColumnValues { get; set; }
    /// <summary>Custom table name, use consts from Alvao.API.Common.Model.CustomTables.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomColumnsModel.html#Alvao_API_Common_Model_CustomColumnsModel_CustomTableName"/>
    public string CustomTableName { get; set; }
    /// <summary>Custom table entity identificator (eg. tHdTicket.iHdTicketId for tHdTicketCust, tPerson.iPersonId for tPersonCust).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomColumnsModel.html#Alvao_API_Common_Model_CustomColumnsModel_EntityId"/>
    public int EntityId { get; set; }
}
