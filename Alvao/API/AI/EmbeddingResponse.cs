using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_EmbeddingResponse.htm"/>
public class EmbeddingResponse {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_EmbeddingResponse_Embedding.htm"/>
    [JsonPropertyAttribute("embedding")]
    public List<double> Embedding { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_EmbeddingResponse_Index.htm"/>
    [JsonPropertyAttribute("index")]
    public int? Index { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_EmbeddingResponse__ctor.htm"/>
    public EmbeddingResponse() { }
}
