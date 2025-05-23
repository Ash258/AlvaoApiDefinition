using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_ChatMessage.htm"/>
public class ChatMessage
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChatMessage_Content.htm"/>
    [JsonPropertyAttribute("content")]
    public string Content { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChatMessage_Role.htm"/>
    [JsonPropertyAttribute("role")]
    public string Role { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_ChatMessage__ctor.htm"/>
    public ChatMessage() { }
}
