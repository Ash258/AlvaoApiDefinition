using Newtonsoft.Json;

namespace Alvao.API.AI;

public class ChatChoiceResponse
{
    [JsonPropertyAttribute("delta")]
    public ChatMessage Delta { get; set; }
    [JsonPropertyAttribute("finish_reason")]
    public string FinishReason { get; set; }
    [JsonPropertyAttribute("index")]
    public int? Index { get; set; }
    [JsonPropertyAttribute("message")]
    public ChatMessage Message { get; set; }
}
