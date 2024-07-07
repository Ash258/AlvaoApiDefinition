using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_ChatChoiceResponse.htm"/>
public class ChatChoiceResponse
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChatChoiceResponse_Delta.htm"/>
    [JsonPropertyAttribute("delta")]
    public ChatMessage Delta { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChatChoiceResponse_FinishReason.htm"/>
    [JsonPropertyAttribute("finish_reason")]
    public string FinishReason { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChatChoiceResponse_Index.htm"/>
    [JsonPropertyAttribute("index")]
    public int? Index { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChatChoiceResponse_Message.htm"/>
    [JsonPropertyAttribute("message")]
    public ChatMessage Message { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_ChatChoiceResponse__ctor.htm"/>
    public ChatChoiceResponse() { }
}
