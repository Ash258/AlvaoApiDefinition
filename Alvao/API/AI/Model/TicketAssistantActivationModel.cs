namespace Alvao.API.AI.Model;

/// <summary>Model representing the activation status of various ticket assistant features.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantActivationModel.html"/>
public class TicketAssistantActivationModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantActivationModel.html#Alvao_API_AI_Model_TicketAssistantActivationModel_CreateSummary"/>
    public bool CreateSummary { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantActivationModel.html#Alvao_API_AI_Model_TicketAssistantActivationModel_IsAssistantVectorEnabled"/>
    public bool IsAssistantVectorEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantActivationModel.html#Alvao_API_AI_Model_TicketAssistantActivationModel_IsDetectMajorIncidentEnabled"/>
    public bool IsDetectMajorIncidentEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantActivationModel.html#Alvao_API_AI_Model_TicketAssistantActivationModel_IsSearchingVectorEnabled"/>
    public bool IsSearchingVectorEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantActivationModel.html#Alvao_API_AI_Model_TicketAssistantActivationModel_ShowSolutionProposal"/>
    public bool ShowSolutionProposal { get; set; }
}
