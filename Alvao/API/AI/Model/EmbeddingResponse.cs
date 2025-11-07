using Newtonsoft.Json;

namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EmbeddingResponse.html"/>
public class EmbeddingResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EmbeddingResponse.html#Alvao_API_AI_Model_EmbeddingResponse_Embedding"/>
    [JsonProperty("embedding")]
    public List<double> Embedding { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.EmbeddingResponse.html#Alvao_API_AI_Model_EmbeddingResponse_Index"/>
    [JsonProperty("index")]
    public int? Index { get; set; }
}
