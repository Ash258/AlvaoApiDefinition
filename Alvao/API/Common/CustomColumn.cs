using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;
using System.Globalization;

namespace Alvao.API.Common;

/// <summary>
/// Facade class grouping custom column methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_CustomColumn.htm"/>
public static class CustomColumn
{

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_CustomColumn_GetAll.htm"/>
    ///
    /// <param name="customTableName"> </param>
    /// <param name="entityId"> </param>
    public static IEnumerable<ColumnValue> GetAll(
        string customTableName,
        int entityId
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_CustomColumn_GetAllColumns.htm"/>
    ///
    /// <param name="customTableName"> </param>
    public static IEnumerable<tColumn> GetAllColumns(
        string customTableName
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get value of custom column</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_CustomColumn_GetValue.htm"/>
    ///
    /// <param name="tableName">Custom table name, use consts from Alvao.API.Common.Model.CustomTables. Supported tables are CustomTables.tHdTicket, CustomTables.tHdSection, CustomTables.tPerson and CustomTables.tAccount</param>
    /// <param name="columnName">Custom column name</param>
    /// <param name="entityId">Custom table entity identificator (eg. tHdTicket.iHdTicketId for CustomTables.tHdTicket, tPerson.iPersonId for CustomTables.tPerson).</param>
    /// <param name="language">Column value language (for localized values)</param>
    /// <param name="timeZone">Column value time zone (for DateTime values)</param>
    /// <param name="returnPersonName">If true, for custom column type user returns it's name, otherwise returns it's id. Default is true.</param>
    public static string GetValue(
        string tableName,
        string columnName,
        int entityId,
        CultureInfo language,
        string timeZone,
        bool returnPersonName = true
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Suggests possible values for custom column matching specific sample</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_CustomColumn_SuggestValues.htm"/>
    ///
    /// <param name="id">Column id (tColumn.iColumnId)</param>
    /// <param name="sectionId">Service id (tHdSection.iHdSectionId) - some values are set only for a specific service.</param>
    /// <param name="sample">Sample for matching column values</param>
    /// <param name="localeId">Values are returned in this language (if translation is available)</param>
    /// <param name="top">Set number of returned values (default 100)</param>
    public static IEnumerable<vColumnValueLoc> SuggestValues(
        int id,
        int? sectionId,
        string sample,
        int localeId,
        int top = 100
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Updates custom column values.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_CustomColumn_UpdateValues.htm"/>
    ///
    /// <param name="model">Custom columns model</param>
    /// <param name="auditLogChanges">Log tPersonCust changes to audit log.</param>
    public static void UpdateValues(
        CustomColumnsModel model,
        bool auditLogChanges = false
    )
    { throw new System.NotImplementedException(); }
}
