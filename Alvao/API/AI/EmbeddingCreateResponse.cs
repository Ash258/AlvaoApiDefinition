using Newtonsoft.Json;

namespace Alvao.API.AI;

public class EmbeddingCreateResponse : BaseResponse
{
    [JsonPropertyAttribute("data")]
    public List<EmbeddingResponse> Data { get; set; }
    [JsonPropertyAttribute("error")]
    public Error Error { get; set; }
    [JsonPropertyAttribute("model")]
    public string Model { get; set; }
    [JsonPropertyAttribute("object")]
    public string ObjectTypeName { get; set; }
    public bool Successful { get; }
    [JsonPropertyAttribute("usage")]
    public UsageResponse Usage { get; set; }

    public EmbeddingCreateResponse() { }
}
