namespace Alvao.API.SD.Model;

public class TicketInfoTableRowModel
{
    public string Label { get; set; }
    public string Value { get; set; }

    public TicketInfoTableRowModel(
        string label,
        string value
    )
    { }

    /// <param name="ticketDetail"> </param>
    public static List<TicketInfoTableRowModel> GetTicketInfoTableRows(
        TicketDetailsModel ticketDetail
    )
    { throw new System.NotImplementedException(); }
}
