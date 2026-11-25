namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DirectRiskRelation.html"/>
public class DirectRiskRelation {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DirectRiskRelation.html#Alvao_API_AM_Model_DirectRiskRelation_AssetId"/>
    public int AssetId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DirectRiskRelation.html#Alvao_API_AM_Model_DirectRiskRelation_NewRelationRiskLevel"/>
    public RiskValue NewRelationRiskLevel { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DirectRiskRelation.html#Alvao_API_AM_Model_DirectRiskRelation_ThreatId"/>
    public int ThreatId { get; set; }
}
