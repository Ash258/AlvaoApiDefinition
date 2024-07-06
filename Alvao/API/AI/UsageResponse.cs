using Newtonsoft.Json;

namespace Alvao.API.AI;

public class UsageResponse
{
    [JsonPropertyAttribute("completion_tokens")]
    public int? CompletionTokens { get; set; }
    [JsonPropertyAttribute("prompt_tokens")]
    public int PromptTokens { get; set; }
    [JsonPropertyAttribute("total_tokens")]
    public int TotalTokens { get; set; }

    public UsageResponse() { }
}
