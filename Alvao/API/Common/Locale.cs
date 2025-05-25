using Alvao.API.Common.Model;

namespace Alvao.API.Common;

/// <summary>Facade class grouping Localization methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Locale.html"/>
public static class Locale {
    /// <summary>Returns LCID number for default database language.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Locale.html#Alvao_API_Common_Locale_GetDatabaseLocaleId"/>
    /// <returns>LCID number (tDb.iDbLocaleId)</returns>
    public static int GetDatabaseLocaleId() { throw new NotImplementedException(); }
    /// <summary>Returns all enabled languages with their names.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Locale.html#Alvao_API_Common_Locale_GetEnabledLanguageNames"/>
    /// <returns>List of enabled languages with id and name.</returns>
    public static IEnumerable<LanguageNameModel> GetEnabledLanguageNames() { throw new NotImplementedException(); }
    /// <summary>Returns all enabled languages.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Locale.html#Alvao_API_Common_Locale_GetEnabledLanguages"/>
    /// <returns>List of enabled languages with id and two letter abbreviation.</returns>
    public static IEnumerable<LanguageModel> GetEnabledLanguages() { throw new NotImplementedException(); }
}
