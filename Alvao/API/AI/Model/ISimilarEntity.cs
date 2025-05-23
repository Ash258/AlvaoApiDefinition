namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ISimilarEntity.html"/>
public interface ISimilarEntity {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ISimilarEntity.html#Alvao_API_AI_Model_ISimilarEntity_CommunicationVector"/>
    string CommunicationVector { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ISimilarEntity.html#Alvao_API_AI_Model_ISimilarEntity_FieldsVector"/>
    string FieldsVector { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ISimilarEntity.html#Alvao_API_AI_Model_ISimilarEntity_Id"/>
    int Id { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ISimilarEntity.html#Alvao_API_AI_Model_ISimilarEntity_ObjectsVector"/>
    string ObjectsVector { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ISimilarEntity.html#Alvao_API_AI_Model_ISimilarEntity_Similarity"/>
    double? Similarity { get; set; }

}
