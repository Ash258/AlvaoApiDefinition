using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.EmbeddingCreateResponse.html"/>
public class EmbeddingCreateResponse : BaseResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.EmbeddingCreateResponse.html#Alvao_API_AI_EmbeddingCreateResponse_Data"/>
    [JsonProperty("data")]
    public List<EmbeddingResponse> Data { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.EmbeddingCreateResponse.html#Alvao_API_AI_EmbeddingCreateResponse_Model"/>
    [JsonProperty("model")]
    public string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.EmbeddingCreateResponse.html#Alvao_API_AI_EmbeddingCreateResponse_Usage"/>
    [JsonProperty("usage")]
    public UsageResponse Usage { get; set; }
}
