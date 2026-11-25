namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleChunkResult.html"/>
public class ExternalArticleChunkResult {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleChunkResult.html#Alvao_API_SD_Model_ExternalArticleChunkResult_ChunkId"/>
    public int ChunkId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleChunkResult.html#Alvao_API_SD_Model_ExternalArticleChunkResult_Content"/>
    public string Content { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleChunkResult.html#Alvao_API_SD_Model_ExternalArticleChunkResult_ContentVector"/>
    public string ContentVector { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleChunkResult.html#Alvao_API_SD_Model_ExternalArticleChunkResult_CosineDistance"/>
    public float CosineDistance { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleChunkResult.html#Alvao_API_SD_Model_ExternalArticleChunkResult_ExternalArticleId"/>
    public int ExternalArticleId { get; set; }
}
