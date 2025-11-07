using Newtonsoft.Json;

namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChatChoiceResponse.html"/>
public class ChatChoiceResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChatChoiceResponse.html#Alvao_API_AI_Model_ChatChoiceResponse_Delta"/>
    [JsonProperty("delta")]
    public ChatMessage Delta { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChatChoiceResponse.html#Alvao_API_AI_Model_ChatChoiceResponse_FinishReason"/>
    [JsonProperty("finish_reason")]
    public string FinishReason { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChatChoiceResponse.html#Alvao_API_AI_Model_ChatChoiceResponse_Index"/>
    [JsonProperty("index")]
    public int? Index { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChatChoiceResponse.html#Alvao_API_AI_Model_ChatChoiceResponse_Message"/>
    [JsonProperty("message")]
    public ChatMessage Message { get; set; }
}
