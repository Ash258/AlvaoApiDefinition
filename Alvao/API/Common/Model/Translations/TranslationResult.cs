namespace Alvao.API.Common.Model.Translations;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.TranslationResult.html"/>
public class TranslationResult {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.TranslationResult.html#Alvao_API_Common_Model_Translations_TranslationResult_DetectedLanguage"/>
    public DetectedLanguage DetectedLanguage { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.TranslationResult.html#Alvao_API_Common_Model_Translations_TranslationResult_Translations"/>
    public List<Translation> Translations { get; set; }

}
