namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.SimilarEntity.html"/>
public class SimilarEntity : ISimilarEntity {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.SimilarEntity.html#Alvao_API_AI_Model_SimilarEntity_CommunicationVector"/>
    public string CommunicationVector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.SimilarEntity.html#Alvao_API_AI_Model_SimilarEntity_FieldsVector"/>
    public string FieldsVector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.SimilarEntity.html#Alvao_API_AI_Model_SimilarEntity_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.SimilarEntity.html#Alvao_API_AI_Model_SimilarEntity_MajorIncidentScore"/>
    public double MajorIncidentScore { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.SimilarEntity.html#Alvao_API_AI_Model_SimilarEntity_ObjectsVector"/>
    public string ObjectsVector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.SimilarEntity.html#Alvao_API_AI_Model_SimilarEntity_Similarity"/>
    public double? Similarity { get; set; }
}
