namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html"/>
public class AssistantTicketTabModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_EntityInfo"/>
    public EntityInfo EntityInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_IsSimilarKnowledgeArticlesError"/>
    public bool IsSimilarKnowledgeArticlesError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_IsSimilarServicesError"/>
    public bool IsSimilarServicesError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_IsSimilarSolutionsError"/>
    public bool IsSimilarSolutionsError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_IsSimilarTicketsError"/>
    public bool IsSimilarTicketsError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_MajorIncident"/>
    public MajorIncidentModel MajorIncident { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_SimilarKnowledgeArticles"/>
    public List<KnowledgeTile> SimilarKnowledgeArticles { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_SimilarServices"/>
    public List<ServiceTile> SimilarServices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_SimilarSolutions"/>
    public List<TicketTile> SimilarSolutions { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantTicketTabModel.html#Alvao_API_AI_Model_AssistantTicketTabModel_SimilarTickets"/>
    public List<TicketTile> SimilarTickets { get; set; }
}
