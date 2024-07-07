namespace Alvao.API.SD.Model;

public class TicketMessageTag
{
    public string Prefix { get; set; }
    public string Suffix { get; set; }

    public TicketMessageTag() { }
    public TicketMessageTag(
        string prefix,
        string suffix
    )
    { }

    /// <param name="text"> </param>
    public int? GetIdFromText(
        string text
    )
    { throw new System.NotImplementedException(); }
}
