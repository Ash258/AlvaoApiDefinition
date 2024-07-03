using Newtonsoft.Json;

namespace Alvao.API.AI;

public class ChoiceResponse
{
    [JsonPropertyAttribute("finish_reason")]
    public string FinishReason { get; set; }
    [JsonPropertyAttribute("index")]
    public int? Index { get; set; }
    [JsonPropertyAttribute("text")]
    public string Text { get; set; }
}
