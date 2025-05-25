using System.Globalization;
using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <summary>Facade class grouping custom column methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.CustomColumn.html"/>
public static class CustomColumn {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.CustomColumn.html#Alvao_API_Common_CustomColumn_GetAll_System_String_System_Int32_"/>
    public static IEnumerable<ColumnValue> GetAll(string customTableName, int entityId) { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.CustomColumn.html#Alvao_API_Common_CustomColumn_GetAllColumns_System_String_"/>
    public static IEnumerable<tColumn> GetAllColumns(string customTableName) { throw new System.NotImplementedException(); }
    /// <summary>Get value of custom column</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.CustomColumn.html#Alvao_API_Common_CustomColumn_GetValue_System_String_System_String_System_Int32_System_Globalization_CultureInfo_System_String_System_Boolean_System_Boolean_System_Boolean_"/>
    /// <param name="tableName">Custom table name, use consts from Alvao.API.Common.Model.CustomTables. Supported tables are CustomTables.tHdTicket, CustomTables.tHdSection, CustomTables.tPerson and CustomTables.tAccount</param>
    /// <param name="columnName">Custom column name</param>
    /// <param name="entityId">Custom table entity identificator (eg. tHdTicket.iHdTicketId for CustomTables.tHdTicket, tPerson.iPersonId for CustomTables.tPerson).</param>
    /// <param name="language">Column value language (for localized values)</param>
    /// <param name="timeZone">Column value time zone (for DateTime values)</param>
    /// <param name="returnPersonName">If true, for custom column type user returns it's name, otherwise returns it's id. Default is true.</param>
    /// <param name="returnBitAsNumber">If true, for custom column type bit returns &quot;1&quot;/&quot;0&quot;, otherwise returns localized values &quot;Yes&quot;/&quot;No&quot;. Default is true.</param>
    /// <param name="formatDouble">If true, for custom column type float returns localized value in the preferred language. Default is false.</param>
    /// <returns>Column value</returns>
    public static string GetValue(string tableName, string columnName, int entityId, CultureInfo language, string timeZone, bool returnPersonName = true, bool returnBitAsNumber = true, bool formatDouble = false) { throw new System.NotImplementedException(); }
    /// <summary>Suggests possible values for custom column matching specific sample</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.CustomColumn.html#Alvao_API_Common_CustomColumn_SuggestValues_System_Int32_System_Nullable_System_Int32__System_String_System_Int32_System_Int32_"/>
    /// <param name="id">Column id (tColumn.iColumnId)</param>
    /// <param name="sectionId">Service id (tHdSection.iHdSectionId) - some values are set only for a specific service.</param>
    /// <param name="sample">Sample for matching column values</param>
    /// <param name="localeId">Values are returned in this language (if translation is available)</param>
    /// <param name="top">Set number of returned values (default 100)</param>
    public static IEnumerable<vColumnValueLoc> SuggestValues(int id, int? sectionId, string sample, int localeId, int top = 100) { throw new System.NotImplementedException(); }
    /// <summary>Updates custom column values.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.CustomColumn.html#Alvao_API_Common_CustomColumn_UpdateValues_Alvao_API_Common_Model_CustomColumnsModel_System_Boolean_"/>
    /// <param name="model">Custom columns model</param>
    /// <param name="auditLogChanges">Log tPersonCust changes to audit log.</param>
    /// <exception cref="ArgumentNullException">Throws when model is null.</exception>
    public static void UpdateValues(CustomColumnsModel model, bool auditLogChanges = false) { throw new System.NotImplementedException(); }
}
