using Newtonsoft.Json;

namespace Alvao.API.AI;

public class ChoiceResponse
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChoiceResponse_FinishReason.htm"/>
    [JsonPropertyAttribute("finish_reason")]
    public string FinishReason { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChoiceResponse_Index.htm"/>
    [JsonPropertyAttribute("index")]
    public int? Index { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_ChoiceResponse_Text.htm"/>
    [JsonPropertyAttribute("text")]
    public string Text { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_ChoiceResponse__ctor.htm"/>
    public ChoiceResponse() { }
}
