namespace Alvao.API.AI.Model;

public class EntityInfo
{
    public bool AssistantEnabled { get; }
    public string CommunicationVector { get; set; }
    public bool DetectMajorIncident { get; set; }
    public string FieldsVector { get; set; }
    public bool FindSimilarTickets { get; set; }
    public bool FindTicketsSolution { get; set; }
    public int Id { get; set; }
    public bool IsKnowledge { get; set; }
    public string Message { get; set; }
    public string ObjectsVector { get; set; }
    public bool RecommendServicesForTickets { get; set; }
    public int SectionId { get; set; }
    public bool ShowSolutionProposal { get; set; }
    public bool ShowSummary { get; set; }
    public string SolutionProposal { get; set; }
    public string Subject { get; set; }
    public string Summary { get; set; }
}
