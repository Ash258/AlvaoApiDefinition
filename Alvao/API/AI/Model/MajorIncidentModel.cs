namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_Model_MajorIncidentModel.htm"/>
public class MajorIncidentModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_BadHealthServices.htm"/>
    public List<SimilarEntity> BadHealthServices { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_CriticalServiceNodes.htm"/>
    public List<IncidentEntity> CriticalServiceNodes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_CriticalServiceSection.htm"/>
    public IncidentEntity CriticalServiceSection { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_Formula.htm"/>
    public string Formula { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_RecentChanges.htm"/>
    public List<SimilarEntity> RecentChanges { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_RecentIncidentHours.htm"/>
    public double RecentIncidentHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_RecentIncidents.htm"/>
    public List<SimilarEntity> RecentIncidents { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_Score.htm"/>
    public double Score { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_MajorIncidentModel_SimilarIncidents.htm"/>
    public List<SimilarEntity> SimilarIncidents { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Model_MajorIncidentModel__ctor.htm"/>
    public MajorIncidentModel() { }
}
