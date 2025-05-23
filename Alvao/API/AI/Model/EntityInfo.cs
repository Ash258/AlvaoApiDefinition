namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_Model_EntityInfo.htm"/>
public class EntityInfo {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_AssistantEnabled.htm"/>
    public bool AssistantEnabled { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_CommunicationVector.htm"/>
    public string CommunicationVector { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_DetectMajorIncident.htm"/>
    public bool DetectMajorIncident { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_FieldsVector.htm"/>
    public string FieldsVector { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_FindSimilarTickets.htm"/>
    public bool FindSimilarTickets { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_FindTicketsSolution.htm"/>
    public bool FindTicketsSolution { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_Id.htm"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_IsKnowledge.htm"/>
    public bool IsKnowledge { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_Message.htm"/>
    public string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_ObjectsVector.htm"/>
    public string ObjectsVector { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_RecommendServicesForTickets.htm"/>
    public bool RecommendServicesForTickets { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_SectionId.htm"/>
    public int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_ShowSolutionProposal.htm"/>
    public bool ShowSolutionProposal { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_ShowSummary.htm"/>
    public bool ShowSummary { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_SolutionProposal.htm"/>
    public string SolutionProposal { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_Subject.htm"/>
    public string Subject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_EntityInfo_Summary.htm"/>
    public string Summary { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Model_EntityInfo__ctor.htm"/>
    public EntityInfo() { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Model_EntityInfo_GetCleanedText.htm"/>
    public string GetCleanedText() { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Model_EntityInfo_GetCommunicationText.htm"/>
    public string GetCommunicationText() { throw new System.NotImplementedException(); }
}
