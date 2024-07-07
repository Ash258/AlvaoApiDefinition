namespace Alvao.API.SD;

/// <summary>
/// Facade class grouping news methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_News.htm"/>
public static class News
{

    /// <summary>Send news post to recipients</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_News_Send_1.htm"/>
    /// <param name="newsId">News post ID</param>
    /// <param name="recipients">List of email addresses of recipients</param>
    /// <param name="newsLink">Web link of the news that will be embeded into mail message</param>
    public static void Send(
        int newsId,
        List<string> recipients,
        string newsLink
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Send news post by email</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_News_Send.htm"/>
    /// <param name="newsId">News post ID</param>
    /// <param name="sendToRequesters">Send to requesters</param>
    /// <param name="sendToSectionTeam">Send to section team</param>
    /// <param name="specificRecipients">Specific recipients of email containing news</param>
    public static void Send(
        int newsId,
        bool sendToRequesters,
        bool sendToSectionTeam,
        string specificRecipients
    )
    { throw new System.NotImplementedException(); }
}
