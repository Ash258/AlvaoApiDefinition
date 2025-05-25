namespace Alvao.API.SD;

/// <summary>Facade class grouping article methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html"/>
public static class Article {
    /// <summary>Delete all translation of article with id articleId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_DeleteAllTranslations_System_Int32_"/>
    /// <param name="articleId">Id of article for which delete all translations.</param>
    public static void DeleteAllTranslations(int articleId) { throw new NotImplementedException(); }
    /// <summary>Translate Article to all enabled languages.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_Translate_System_Int32_"/>
    /// <param name="id">Id of article for translate.</param>
    /// <returns>Whether the translation was successful.</returns>
    public static bool Translate(int id) { throw new NotImplementedException(); }
    /// <summary>Translate Article to language corresponding to language with id localeId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_TranslateToLanguage_System_Int32_System_Int32_"/>
    /// <param name="articleId">Id of article for translate.</param>
    /// <param name="localeId">Id of language to be translated.</param>
    /// <returns>Whether the translation was successful.</returns>
    public static bool TranslateToLanguage(int articleId, int localeId) { throw new NotImplementedException(); }
}
