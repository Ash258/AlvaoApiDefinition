using Newtonsoft.Json;

namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChoiceResponse.html"/>
public class ChoiceResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChoiceResponse.html#Alvao_API_AI_Model_ChoiceResponse_FinishReason"/>
    [JsonProperty("finish_reason")]
    public string FinishReason { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChoiceResponse.html#Alvao_API_AI_Model_ChoiceResponse_Index"/>
    [JsonProperty("index")]
    public int? Index { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChoiceResponse.html#Alvao_API_AI_Model_ChoiceResponse_Text"/>
    [JsonProperty("text")]
    public string Text { get; set; }
}
