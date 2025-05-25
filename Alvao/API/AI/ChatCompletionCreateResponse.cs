using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.ChatCompletionCreateResponse.html"/>
public class ChatCompletionCreateResponse : BaseResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.ChatCompletionCreateResponse.html#Alvao_API_AI_ChatCompletionCreateResponse_Choices"/>
    [JsonProperty("choices")]
    public List<ChatChoiceResponse> Choices { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.ChatCompletionCreateResponse.html#Alvao_API_AI_ChatCompletionCreateResponse_CreatedAt"/>
    [JsonProperty("created")]
    public int CreatedAt { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.ChatCompletionCreateResponse.html#Alvao_API_AI_ChatCompletionCreateResponse_Id"/>
    [JsonProperty("id")]
    public string Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.ChatCompletionCreateResponse.html#Alvao_API_AI_ChatCompletionCreateResponse_Model"/>
    [JsonProperty("model")]
    public string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.ChatCompletionCreateResponse.html#Alvao_API_AI_ChatCompletionCreateResponse_Usage"/>
    [JsonProperty("usage")]
    public UsageResponse Usage { get; set; }
}
