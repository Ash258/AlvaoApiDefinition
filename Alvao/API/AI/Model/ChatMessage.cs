using Newtonsoft.Json;

namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChatMessage.html"/>
public class ChatMessage {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChatMessage.html#Alvao_API_AI_Model_ChatMessage_Content"/>
    [JsonProperty("content")]
    public string Content { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ChatMessage.html#Alvao_API_AI_Model_ChatMessage_Role"/>
    [JsonProperty("role")]
    public string Role { get; set; }
}
