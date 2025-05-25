namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html"/>
public class CardModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_ButtonLink"/>
    public string ButtonLink { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_ButtonText"/>
    public string ButtonText { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_CardLocaleId"/>
    public int CardLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_ConversationId"/>
    public string ConversationId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_IconBackgroundHex"/>
    public string IconBackgroundHex { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_IconId"/>
    public int? IconId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_RequestTag"/>
    public string RequestTag { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_RestApiUrl"/>
    public string RestApiUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_SectionId"/>
    public int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_TenantId"/>
    public string TenantId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_Text"/>
    public string Text { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_TicketId"/>
    public int TicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_Tickets"/>
    public List<BasicTicketInfo> Tickets { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_Title"/>
    public string Title { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_Type"/>
    public CardType Type { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel_WebAppUrl"/>
    public string WebAppUrl { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel__ctor"/>
    public CardModel() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CardModel.html#Alvao_API_SD_Model_CardModel__ctor_System_String_Alvao_API_SD_Model_CardType_System_Int32_"/>
    public CardModel(string title, CardType type, int localeId = 1033) { }
}
