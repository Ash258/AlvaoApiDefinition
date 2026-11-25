using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <summary>Facade class grouping Localization methods.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Locale.html"/>
public static class Locale {
    /// <summary>Returns LCID number for default database language.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Locale.html#Alvao_API_Common_Locale_GetDatabaseLocaleId"/>
    /// <returns>LCID number (tDb.iDbLocaleId)</returns>
    public static int GetDatabaseLocaleId() { throw new NotImplementedException(); }
    /// <summary>Returns all enabled languages with their names.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Locale.html#Alvao_API_Common_Locale_GetEnabledLanguageNames"/>
    /// <returns>List of enabled languages with id and name.</returns>
    public static IEnumerable<LanguageNameModel> GetEnabledLanguageNames() { throw new NotImplementedException(); }
    /// <summary>Returns all enabled languages.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Locale.html#Alvao_API_Common_Locale_GetEnabledLanguages"/>
    /// <returns>List of enabled languages with id and two letter abbreviation.</returns>
    public static IEnumerable<LanguageModel> GetEnabledLanguages() { throw new NotImplementedException(); }
    /// <summary>Returns supported DB languages.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Locale.html#Alvao_API_Common_Locale_GetSupportedLanguages_System_Boolean_"/>
    /// <param name="onlyEnabled">Specify if only enabled supported laguages should be returned. Default is false.</param>
    /// <returns>List of supported DB languages.</returns>
    public static IEnumerable<tLocale> GetSupportedLanguages(bool onlyEnabled = false) { throw new NotImplementedException(); }
    /// <summary>Marks record as needing update in localization table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Locale.html#Alvao_API_Common_Locale_MarkNeedUpdate_System_String_System_String_System_Int32_"/>
    /// <param name="table">Name of table (tLocalization.sTable)</param>
    /// <param name="attribute">Column name (tLocalization.sAttribute)</param>
    /// <param name="recordId">ID of record in target table (tLocalization.iRecordId)</param>
    public static void MarkNeedUpdate(string table, string attribute, int recordId) { throw new NotImplementedException(); }
}
