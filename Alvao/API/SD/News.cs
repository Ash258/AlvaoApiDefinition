namespace Alvao.API.SD;

/// <summary>Facade class grouping news methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.News.html"/>
public static class News {
    /// <summary>Delete all translation of news with id newsId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.News.html#Alvao_API_SD_News_DeleteAllTranslations_System_Int32_"/>
    /// <param name="newsId">Id of news for which delete all translations.</param>
    public static void DeleteAllTranslations(int newsId) { throw new NotImplementedException(); }
    /// <summary>Gets news db model by id</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.News.html#Alvao_API_SD_News_GetById_System_Int32_"/>
    /// <param name="id">News ID (News.id)</param>
    /// <exception cref="UnauthorizedAccessException">Throws when user does not have rights to read the license.</exception>
    public static Alvao.API.Common.Model.Database.News GetById(int id) { throw new NotImplementedException(); }
    /// <summary>Send news post by email</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.News.html#Alvao_API_SD_News_Send_System_Int32_System_Boolean_System_Boolean_System_String_"/>
    /// <param name="newsId">News post ID</param>
    /// <param name="sendToRequesters">Send to requesters</param>
    /// <param name="sendToSectionTeam">Send to section team</param>
    /// <param name="specificRecipients">Specific recipients of email containing news</param>
    public static void Send(int newsId, bool sendToRequesters, bool sendToSectionTeam, string specificRecipients) { throw new NotImplementedException(); }
    /// <summary>Send news post to recipients</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.News.html#Alvao_API_SD_News_Send_System_Int32_System_Collections_Generic_List_System_String__System_String_"/>
    /// <param name="newsId">News post ID</param>
    /// <param name="recipients">List of email addresses of recipients</param>
    /// <param name="newsLink">Web link of the news that will be embeded into mail message</param>
    public static void Send(int newsId, List<string> recipients, string newsLink) { throw new NotImplementedException(); }
    /// <summary>Create new translations of news with id newsId to all enabled languages with less than 25000 characters.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.News.html#Alvao_API_SD_News_Translate_System_Int32_"/>
    /// <param name="newsId">Id of news to translate.</param>
    /// <returns>Whether the translation was successful.</returns>
    public static bool Translate(int newsId) { throw new NotImplementedException(); }
    /// <summary>Create new translation of news with id newsId to language with id localeId with less than 25000 characters.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.News.html#Alvao_API_SD_News_TranslateToLanguage_System_Int32_System_Int32_"/>
    /// <param name="newsId">Id of new for translation.</param>
    /// <param name="localeId">Id of languages to be translated.</param>
    /// <returns>Whether the translation was successful.</returns>
    public static bool TranslateToLanguage(int newsId, int localeId) { throw new NotImplementedException(); }
    /// <summary>Create new translation of news with id newsId to language with id localeId of any length.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.News.html#Alvao_API_SD_News_TranslateToLanguageAsync_System_Int32_System_Int32_"/>
    /// <param name="newsId">Id of new for translation.</param>
    /// <param name="localeId">Id of languages to be translated.</param>
    /// <returns>Whether the translation was successful.</returns>
    public static Task<bool> TranslateToLanguageAsync(int newsId, int localeId) { throw new NotImplementedException(); }
}
