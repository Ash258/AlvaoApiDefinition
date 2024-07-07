namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_Model_IncidentEntity.htm"/>
public class IncidentEntity
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_IncidentEntity_BadHealthPercent.htm"/>
    public double BadHealthPercent { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_IncidentEntity_Description.htm"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_IncidentEntity_Id.htm"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_IncidentEntity_MajorIncidentScore.htm"/>
    public double MajorIncidentScore { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_IncidentEntity_Name.htm"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_IncidentEntity_Type.htm"/>
    public string Type { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Model_IncidentEntity__ctor.htm"/>
    public IncidentEntity() { }
}
