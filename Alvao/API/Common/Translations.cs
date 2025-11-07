namespace Alvao.API.Common;

/// <summary>Facade class grouping translation methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Translations.html"/>
public static class Translations {
    /// <summary>Detect language in text.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Translations.html#Alvao_API_Common_Translations_DetectLanguage_System_String_"/>
    /// <param name="text">Text for which the language is to be detected.</param>
    /// <returns>Id of detected language.</returns>
    public static int DetectLanguage(string text) { throw new NotImplementedException(); }
    /// <summary>Check if translation is enabled.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Translations.html#Alvao_API_Common_Translations_IsEnabled"/>
    /// <returns>true if translations are enabled, false otherwise</returns>
    public static bool IsEnabled() { throw new NotImplementedException(); }
    /// <summary>This method translates list of phrases to toLanguage with less than 25000 characters.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Translations.html#Alvao_API_Common_Translations_Translate_System_Collections_Generic_List_System_String__System_String_"/>
    /// <param name="phrases">List of phrases for translation</param>
    /// <param name="toLanguage">Target language</param>
    /// <returns>Translated phrases to toLanguage</returns>
    public static List<string> Translate(List<string> phrases, string toLanguage) { throw new NotImplementedException(); }
    /// <summary>This method asynchronously translates a list of phrases to toLanguage of any length.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Translations.html#Alvao_API_Common_Translations_TranslateAsync_System_Collections_Generic_List_System_String__System_String_"/>
    /// <param name="phrases">List of phrases for translation</param>
    /// <param name="toLanguage">Target language</param>
    /// <returns>Translated phrases to toLanguage</returns>
    public static Task<List<string>> TranslateAsync(List<string> phrases, string toLanguage) { throw new NotImplementedException(); }
}
