namespace Alvao.API.Common;

/// <summary>Facade class grouping translation methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Translations.html"/>
public static class Translations {
    /// <summary>Detect language in text.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Translations.html#Alvao_API_Common_Translations_DetectLanguage_System_String_"/>
    /// <param name="text">Text for which the language is to be detected.</param>
    /// <returns>Id of detected language.</returns>
    public static int DetectLanguage(string text) { throw new System.NotImplementedException(); }
    /// <summary>This method translate list of phrases to toLanguage.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Translations.html#Alvao_API_Common_Translations_Translate_System_Collections_Generic_List_System_String__System_String_"/>
    /// <param name="phrases">List of phrases for translation</param>
    /// <param name="toLanguage">Target language</param>
    /// <returns>Translated phrases to toLanguage</returns>
    public static List<string> Translate(List<string> phrases, string toLanguage) { throw new System.NotImplementedException(); }
}
