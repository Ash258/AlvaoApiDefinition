using Newtonsoft.Json;

namespace Alvao.API.AI;

public class ChatCompletionCreateResponse : BaseResponse
{
    [JsonPropertyAttribute("created")]
    public int CreatedAt { get; set; }
    [JsonPropertyAttribute("error")]
    public Error Error { get; set; }
    [JsonPropertyAttribute("choices")]
    public List<ChatChoiceResponse> Choices { get; set; }
    [JsonPropertyAttribute("id")]
    public string Id { get; set; }
    [JsonPropertyAttribute("model")]
    public string Model { get; set; }
    [JsonPropertyAttribute("object")]
    public string ObjectTypeName { get; set; }
    public bool Successful { get; }
    [JsonPropertyAttribute("usage")]
    public UsageResponse Usage { get; set; }

    public ChatCompletionCreateResponse() { }
}
