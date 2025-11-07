using Newtonsoft.Json;

namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.UsageResponse.html"/>
public class UsageResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.UsageResponse.html#Alvao_API_AI_Model_UsageResponse_CompletionTokens"/>
    [JsonProperty("completion_tokens")]
    public int? CompletionTokens { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.UsageResponse.html#Alvao_API_AI_Model_UsageResponse_PromptTokens"/>
    [JsonProperty("prompt_tokens")]
    public int PromptTokens { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.UsageResponse.html#Alvao_API_AI_Model_UsageResponse_TotalTokens"/>
    [JsonProperty("total_tokens")]
    public int TotalTokens { get; set; }
}
