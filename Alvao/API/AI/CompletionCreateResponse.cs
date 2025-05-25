using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.CompletionCreateResponse.html"/>
public class CompletionCreateResponse : BaseResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.CompletionCreateResponse.html#Alvao_API_AI_CompletionCreateResponse_Choices"/>
    [JsonProperty("choices")]
    public List<ChoiceResponse> Choices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.CompletionCreateResponse.html#Alvao_API_AI_CompletionCreateResponse_CreatedAt"/>
    [JsonProperty("created")]
    public int CreatedAt { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.CompletionCreateResponse.html#Alvao_API_AI_CompletionCreateResponse_Id"/>
    [JsonProperty("id")]
    public string Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.CompletionCreateResponse.html#Alvao_API_AI_CompletionCreateResponse_Model"/>
    [JsonProperty("model")]
    public string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.CompletionCreateResponse.html#Alvao_API_AI_CompletionCreateResponse_Usage"/>
    [JsonProperty("usage")]
    public UsageResponse Usage { get; set; }
}
