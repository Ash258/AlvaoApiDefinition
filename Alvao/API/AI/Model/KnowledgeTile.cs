namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.KnowledgeTile.html"/>
public class KnowledgeTile : SimilarEntity, ISimilarEntity {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.KnowledgeTile.html#Alvao_API_AI_Model_KnowledgeTile_Description"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.KnowledgeTile.html#Alvao_API_AI_Model_KnowledgeTile_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.KnowledgeTile.html#Alvao_API_AI_Model_KnowledgeTile_Url"/>
    public string Url { get; set; }
}
