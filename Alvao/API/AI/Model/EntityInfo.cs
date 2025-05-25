namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html"/>
public class EntityInfo {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_AssistantEnabled"/>
    public bool AssistantEnabled { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_CommunicationVector"/>
    public string CommunicationVector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_DetectMajorIncident"/>
    public bool DetectMajorIncident { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_FieldsVector"/>
    public string FieldsVector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_FindSimilarTickets"/>
    public bool FindSimilarTickets { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_FindTicketsSolution"/>
    public bool FindTicketsSolution { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_IsKnowledge"/>
    public bool IsKnowledge { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_IsResolved"/>
    public bool IsResolved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_Keywords"/>
    public string Keywords { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_Message"/>
    public string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_ObjectsVector"/>
    public string ObjectsVector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_RecommendServicesForTickets"/>
    public bool RecommendServicesForTickets { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_SectionId"/>
    public int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_ShowSolutionProposal"/>
    public bool ShowSolutionProposal { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_ShowSummary"/>
    public bool ShowSummary { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_SolutionProposal"/>
    public string SolutionProposal { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_Subject"/>
    public string Subject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_Summary"/>
    public string Summary { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_GetCleanedText"/>
    public string GetCleanedText() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EntityInfo.html#Alvao_API_AI_Model_EntityInfo_GetCommunicationText"/>
    public string GetCommunicationText() { throw new NotImplementedException(); }
}
