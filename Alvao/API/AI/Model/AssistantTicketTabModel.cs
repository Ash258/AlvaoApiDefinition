namespace Alvao.API.AI.Model;

public class AssistantTicketTabModel
{
    public EntityInfo EntityInfo { get; set; }
    public MajorIncidentModel MajorIncident { get; set; }
    public List<SimilarEntity> SimilarKnowledges { get; set; }
    public List<SimilarEntity> SimilarServices { get; set; }
    public List<SimilarEntity> SimilarSolutions { get; set; }
    public List<SimilarEntity> SimilarTickets { get; set; }
}
