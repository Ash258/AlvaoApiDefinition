namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_Model_AssistantTicketTabModel.htm"/>
public class AssistantTicketTabModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_AssistantTicketTabModel_EntityInfo.htm"/>
    public EntityInfo EntityInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_AssistantTicketTabModel_MajorIncident.htm"/>
    public MajorIncidentModel MajorIncident { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_AssistantTicketTabModel_SimilarKnowledges.htm"/>
    public List<SimilarEntity> SimilarKnowledges { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_AssistantTicketTabModel_SimilarServices.htm"/>
    public List<SimilarEntity> SimilarServices { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_AssistantTicketTabModel_SimilarSolutions.htm"/>
    public List<SimilarEntity> SimilarSolutions { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_AssistantTicketTabModel_SimilarTickets.htm"/>
    public List<SimilarEntity> SimilarTickets { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Model_AssistantTicketTabModel__ctor.htm"/>
    public AssistantTicketTabModel() { }
}
