namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.SimilarChunkResult.html"/>
public class SimilarChunkResult {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.SimilarChunkResult.html#Alvao_API_AI_Model_SimilarChunkResult_ChunkId"/>
    public int ChunkId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.SimilarChunkResult.html#Alvao_API_AI_Model_SimilarChunkResult_Content"/>
    public string Content { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.SimilarChunkResult.html#Alvao_API_AI_Model_SimilarChunkResult_EntityId"/>
    public int EntityId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.SimilarChunkResult.html#Alvao_API_AI_Model_SimilarChunkResult_Similarity"/>
    public double Similarity { get; set; }
}
