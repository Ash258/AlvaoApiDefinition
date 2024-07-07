namespace Alvao.API.SD.Model;

public class TicketDetailsModel
{
    public DateTime? dHdTicket { get; set; }
    public DateTime? dHdTicketDeadline { get; set; }
    public string Priority { get; set; }
    public string sHdSection { get; set; }
    public string sHdTicket { get; set; }
    public string sHdTicketDeviceCode { get; set; }
    public string sHdTicketMessageTag { get; set; }
    public string sHdTicketSla { get; set; }
    public string sHdTicketSolverPerson { get; set; }
    public string sHdTicketUser { get; set; }
    public string sHdTicketUserEmail { get; set; }
    public string sHdTicketUserMobile { get; set; }
    public string sHdTicketUserPhone { get; set; }
    public string sUserAccount { get; set; }

    public TicketDetailsModel() { }
}
