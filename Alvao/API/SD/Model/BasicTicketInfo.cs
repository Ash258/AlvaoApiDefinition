namespace Alvao.API.SD.Model;

public class BasicTicketInfo
{
    public int TicketId { get; set; }
    public string TicketName { get; set; }

    public BasicTicketInfo() { }
    public BasicTicketInfo(
        string ticketName,
        int ticketId
    )
    { }
}
