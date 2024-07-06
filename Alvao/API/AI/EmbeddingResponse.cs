using Newtonsoft.Json;

namespace Alvao.API.AI;

public class EmbeddingResponse
{
    [JsonPropertyAttribute("embedding")]
    public List<double> Embedding { get; set; }
    [JsonPropertyAttribute("index")]
    public int? Index { get; set; }

    public EmbeddingResponse() { }
}
