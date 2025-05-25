namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html"/>
public class MajorIncidentModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_BadHealthServices"/>
    public List<ObjectTile> BadHealthServices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_CriticalServiceNodes"/>
    public List<ObjectTile> CriticalServiceNodes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_CriticalServiceSection"/>
    public ServiceTile CriticalServiceSection { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_Formula"/>
    public string Formula { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_IsBadHealthServicesError"/>
    public bool IsBadHealthServicesError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_IsCriticalServiceNodesError"/>
    public bool IsCriticalServiceNodesError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_IsCriticalServiceSectionError"/>
    public bool IsCriticalServiceSectionError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_IsError"/>
    public bool IsError { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_IsRecentChangesError"/>
    public bool IsRecentChangesError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_IsRecentIncidentsError"/>
    public bool IsRecentIncidentsError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_IsSimilarIncidentsError"/>
    public bool IsSimilarIncidentsError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_RecentChanges"/>
    public List<ObjectTile> RecentChanges { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_RecentIncidentHours"/>
    public double RecentIncidentHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_RecentIncidents"/>
    public List<TicketTile> RecentIncidents { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_Score"/>
    public double Score { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.MajorIncidentModel.html#Alvao_API_AI_Model_MajorIncidentModel_SimilarIncidents"/>
    public List<TicketTile> SimilarIncidents { get; set; }
}
