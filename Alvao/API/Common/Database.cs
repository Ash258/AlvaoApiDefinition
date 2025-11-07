namespace Alvao.API.Common;

/// <summary>Facade class grouping database column methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Database.html"/>
public static class Database {
    /// <summary>Data type of the value provided as string</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Database.ValueDataType.html#fields"/>
    public enum ValueDataType {
        Default = 0,
        Text = 1,
    }

    /// <summary>Returns database hash string</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Database.html#Alvao_API_Common_Database_GetHash"/>
    /// <returns>Database hash</returns>
    public static string GetHash() { throw new NotImplementedException(); }
    /// <summary>Checks if Fulltext Search is enabled on the database</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Database.html#Alvao_API_Common_Database_IsFulltextSearchEnabled"/>
    /// <returns>True, if FTS is enabled, false otherwise.</returns>
    public static bool IsFulltextSearchEnabled() { throw new NotImplementedException(); }
    /// <summary>Read a value from the column in the dabatase.  Allowed tables: tHdTicket, tHdTicketCust, TicketForeignKeyInfo, tHdSection, tPerson, tPersonCust, PersonForeignKeyInfo, tRole, TicketStateCust.  For ForeignKeyInfo table info, see: Ticket.ForeignKeyInfo.  Allowed columns for PersonForeignKeyInfo table: AccountName, ManagerName, DelegateName.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Database.html#Alvao_API_Common_Database_ReadColumn_System_Int32_System_String_System_String_"/>
    /// <param name="recordId">Record ID.</param>
    /// <param name="tableName">Table name, case sensitive.</param>
    /// <param name="columnName">Column name, case sensitive.</param>
    /// <exception cref="ArgumentException">Throws when specified recordId or tableName or columnName does not exist in the database.</exception>
    /// <returns>Textual value of the selected column in the database.</returns>
    public static string ReadColumn(int recordId, string tableName, string columnName) { throw new NotImplementedException(); }
    /// <summary>Write a new value to the column in the dabatase. Allowed tables: tHdTicket, tHdTicketCust, tPerson, tPersonCust, tRole, TicketStateCust.  For tHdTicket table info, see: Ticket.UpdateColumnValue.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Database.html#Alvao_API_Common_Database_WriteColumn_System_Int32_System_String_System_String_System_String_Alvao_API_Common_Database_ValueDataType_"/>
    /// <param name="recordId">Record ID.</param>
    /// <param name="tableName">Table name, case sensitive.</param>
    /// <param name="columnName">Column name, case sensitive.</param>
    /// <param name="newValue">Textual value that must be convertible to the target column type. Null is allowed, if specified then null is written to the column.</param>
    /// <param name="newValueDataType">Data type of the newValue parameter. Usable only for integer custom columns with value list when you need to set the text value instead of its Id.</param>
    /// <exception cref="ArgumentException">Throws when specified recordId or tableName or columnName does not exist in the database.</exception>
    public static void WriteColumn(int recordId, string tableName, string columnName, string newValue, Database.ValueDataType newValueDataType = ValueDataType.Default) { throw new NotImplementedException(); }
}
