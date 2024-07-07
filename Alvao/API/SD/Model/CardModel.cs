namespace Alvao.API.SD.Model;

public class CardModel
{
    public string ButtonLink { get; set; }
    public string ButtonText { get; set; }
    public int CardLocaleId { get; set; }
    public string ConversationId { get; set; }
    public string IconBackgroundHex { get; set; }
    public int? IconId { get; set; }
    public string RequestTag { get; set; }
    public string RestApiUrl { get; set; }
    public int SectionId { get; set; }
    public string Text { get; set; }
    public int TicketId { get; set; }
    public List<BasicTicketInfo> Tickets { get; set; }
    public string Title { get; set; }
    public CardType Type { get; set; }
    public string WebAppUrl { get; set; }

    public CardModel() { }
    public CardModel(
        string title,
        CardType type,
        int localeId = 1033
    )
    { }
}
