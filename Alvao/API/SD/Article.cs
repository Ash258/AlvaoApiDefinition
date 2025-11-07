namespace Alvao.API.SD;

/// <summary>Facade class grouping article methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html"/>
public static class Article {
    /// <summary>Checks user rights to read article with ID articleId by user with ID or (current user if null) personId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_CanReadAsync_System_Int32_System_Nullable_System_Int32__System_Threading_CancellationToken_"/>
    /// <param name="articleId">Id of viewed article.</param>
    /// <param name="personId">Id of person who viewed the article.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    public static Task<bool> CanReadAsync(int articleId, int? personId, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Delete all translation of article with id articleId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_DeleteAllTranslations_System_Int32_"/>
    /// <param name="articleId">Id of article for which delete all translations.</param>
    public static void DeleteAllTranslations(int articleId) { throw new NotImplementedException(); }
    /// <summary>Records the feedback on article with ID articleId by user with ID personId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_FeedbackAsync_System_Int32_System_Int32_System_Boolean_System_Threading_CancellationToken_"/>
    /// <param name="articleId">Id of rated article.</param>
    /// <param name="personId">Id of person who rated the article.</param>
    /// <param name="rating">Rating of the article. True = positive, False = negative.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    public static Task FeedbackAsync(int articleId, int personId, bool rating, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    /// <summary>Reset the feedback statistics and number of views for article with ID articleId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_ResetStatisticsAsync_System_Int32_System_Threading_CancellationToken_"/>
    /// <param name="articleId">Id of rated article.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    public static Task ResetStatisticsAsync(int articleId, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    /// <summary>Translate Article to all enabled languages.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_Translate_System_Int32_"/>
    /// <param name="id">Id of article for translate.</param>
    /// <returns>Whether the translation was successful.</returns>
    public static bool Translate(int id) { throw new NotImplementedException(); }
    /// <summary>Translate Article to language corresponding to language with id localeId with less than 25000 characters.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_TranslateToLanguage_System_Int32_System_Int32_"/>
    /// <param name="articleId">Id of article for translate.</param>
    /// <param name="localeId">Id of language to be translated.</param>
    /// <returns>Whether the translation was successful.</returns>
    public static bool TranslateToLanguage(int articleId, int localeId) { throw new NotImplementedException(); }
    /// <summary>Translate Article to language corresponding to language with id localeId of any length.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_TranslateToLanguageAsync_System_Int32_System_Int32_"/>
    /// <param name="articleId">Id of article for translate.</param>
    /// <param name="localeId">Id of language to be translated.</param>
    /// <returns>Whether the translation was successful.</returns>
    public static Task<bool> TranslateToLanguageAsync(int articleId, int localeId) { throw new NotImplementedException(); }
    /// <summary>Records the viewing of article with ID articleId by user with ID personId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Article.html#Alvao_API_SD_Article_ViewAsync_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    /// <param name="articleId">Id of viewed article.</param>
    /// <param name="personId">Id of person who viewed the article.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    public static Task ViewAsync(int articleId, int personId, CancellationToken cancellationToken) { throw new NotImplementedException(); }
}
