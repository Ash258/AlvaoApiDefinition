namespace Alvao.API.SD.Model;

public class NotificationModel
{
    public string Building { get; set; }
    public string DeviceCode { get; set; }
    public DateTime? FirstReactionDeadline { get; set; }
    public int Impact { get; set; }
    public string ImpactName { get; set; }
    public int liHdTicketHdSectionId { get; set; }
    public int liHdTicketSlaId { get; set; }
    public int Priority { get; set; }
    public string PriorityName { get; set; }
    public int RelatedAccountId { get; set; }
    public string Room { get; set; }
    public string Solver { get; set; }
    public string SolverGroup { get; set; }
    public DateTime TickedCreated { get; set; }
    public DateTime? TicketDeadline { get; set; }
    public int TicketId { get; set; }
    public string TicketMessageTag { get; set; }
    public string TicketService { get; set; }
    public string TicketServicePhone { get; set; }
    public string TicketServiceProcess { get; set; }
    public string TicketSla { get; set; }
    public string TicketStatus { get; set; }
    public string TicketTitle { get; set; }
    public int Urgency { get; set; }
    public string UrgencyName { get; set; }
    public string UserAccount { get; set; }
    public string UserEmail { get; set; }
    public string UserMobile { get; set; }
    public string UserName { get; set; }
    public string UserPhone { get; set; }

    public NotificationModel() { }
}
