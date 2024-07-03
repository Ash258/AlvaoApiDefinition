using Newtonsoft.Json;

namespace Alvao.API.AI;

public class ChatMessage
{
    [JsonPropertyAttribute("content")]
    public string Content { get; set; }
    [JsonPropertyAttribute("role")]
    public string Role { get; set; }
}
