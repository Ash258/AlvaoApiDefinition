namespace Alvao.API.SD.Model;

public class ResolvedTicketRelationsModel
{
    public int BeginTicketId { get; set; }
    public int EndTicketId { get; set; }
    public string RelatedTicketMessageTag { get; set; }
    public string RelatedTicketName { get; set; }
    public int RelationTypeId { get; set; }
    public string ResolvedTicketMessageTag { get; set; }
    public string ResolvedTicketName { get; set; }

    public ResolvedTicketRelationsModel() { }
}
