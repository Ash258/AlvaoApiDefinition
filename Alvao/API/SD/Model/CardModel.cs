namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_CardModel.htm"/>
public class CardModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_ButtonLink.htm"/>
    public string ButtonLink { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_ButtonText.htm"/>
    public string ButtonText { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_CardLocaleId.htm"/>
    public int CardLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_ConversationId.htm"/>
    public string ConversationId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_IconBackgroundHex.htm"/>
    public string IconBackgroundHex { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_IconId.htm"/>
    public int? IconId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_RequestTag.htm"/>
    public string RequestTag { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_RestApiUrl.htm"/>
    public string RestApiUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_SectionId.htm"/>
    public int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_Text.htm"/>
    public string Text { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_TicketId.htm"/>
    public int TicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_Tickets.htm"/>
    public List<BasicTicketInfo> Tickets { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_Title.htm"/>
    public string Title { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_Type.htm"/>
    public CardType Type { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CardModel_WebAppUrl.htm"/>
    public string WebAppUrl { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_CardModel__ctor.htm"/>
    public CardModel() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_CardModel__ctor_1.htm"/>
    public CardModel(
        string title,
        CardType type,
        int localeId = 1033
    )
    { }
}
