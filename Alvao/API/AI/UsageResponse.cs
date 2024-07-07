using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_UsageResponse.htm"/>
public class UsageResponse
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_UsageResponse_CompletionTokens.htm"/>
    [JsonPropertyAttribute("completion_tokens")]
    public int? CompletionTokens { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_UsageResponse_PromptTokens.htm"/>
    [JsonPropertyAttribute("prompt_tokens")]
    public int PromptTokens { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_UsageResponse_TotalTokens.htm"/>
    [JsonPropertyAttribute("total_tokens")]
    public int TotalTokens { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_UsageResponse__ctor.htm"/>
    public UsageResponse() { }
}
