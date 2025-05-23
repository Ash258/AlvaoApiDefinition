namespace Alvao.API.Common;

/// <summary>Facade class grouping database column methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Database.htm"/>
public static class Database {
    /// <summary>Data type of the value provided as string</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Database_ValueDataType.htm"/>
    public enum ValueDataType {
        Default = 0,
        Text = 1,
    }

    /// <summary>Returns database hash string</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Database_GetHash.htm"/>
    public static string GetHash() { throw new System.NotImplementedException(); }

    /// <summary>Checks if Fulltext Search is enabled on the database</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Database_IsFulltextSearchEnabled.htm"/>
    public static bool IsFulltextSearchEnabled() { throw new System.NotImplementedException(); }

    /// <summary>Read a value from the column in the dabatase. Allowed tables: tHdTicket, tHdTicketCust, TicketForeignKeyInfo, tHdSection, tPerson, tPersonCust, PersonForeignKeyInfo, tRole, TicketState. For ForeignKeyInfo table info, see: Ticket.ForeignKeyInfo. Allowed columns for PersonForeignKeyInfo table: AccountName, ManagerName, DelegateName.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Database_ReadColumn.htm"/>
    ///
    /// <param name="recordId">Record ID.</param>
    /// <param name="tableName">Table name, case sensitive.</param>
    /// <param name="columnName">Column name, case sensitive.</param>
    public static string ReadColumn(
        int recordId,
        string tableName,
        string columnName
    ) { throw new System.NotImplementedException(); }

    /// <summary>Write a new value to the column in the dabatase. Allowed tables: tHdTicket, tHdTicketCust, tPerson, tPersonCust, tRole, TicketState. For tHdTicket table info, see: Ticket.UpdateColumnValue.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Database_WriteColumn.htm"/>
    ///
    /// <param name="recordId">Record ID.</param>
    /// <param name="tableName">Table name, case sensitive.</param>
    /// <param name="columnName">Column name, case sensitive.</param>
    /// <param name="newValue">Textual value that must be convertible to the target column type. Null is allowed, if specified then null is written to the column.</param>
    /// <param name="newValueDataType">Data type of the newValue parameter. Usable only for integer custom columns with value list when you need to set the text value instead of its Id.</param>
    public static void WriteColumn(
        int recordId,
        string tableName,
        string columnName,
        string newValue,
        Database.ValueDataType newValueDataType = Database.ValueDataType.Default
    ) { throw new System.NotImplementedException(); }
}
