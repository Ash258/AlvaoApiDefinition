using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_EmbeddingCreateResponse.htm"/>
public class EmbeddingCreateResponse : BaseResponse
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_EmbeddingCreateResponse_Data.htm"/>
    [JsonPropertyAttribute("data")]
    public List<EmbeddingResponse> Data { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_BaseResponse_Error.htm"/>
    [JsonPropertyAttribute("error")]
    public Error Error { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_EmbeddingCreateResponse_Model.htm"/>
    [JsonPropertyAttribute("model")]
    public string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_BaseResponse_ObjectTypeName.htm"/>
    [JsonPropertyAttribute("object")]
    public string ObjectTypeName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_BaseResponse_Successful.htm"/>
    public bool Successful { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_EmbeddingCreateResponse_Usage.htm"/>
    [JsonPropertyAttribute("usage")]
    public UsageResponse Usage { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_EmbeddingCreateResponse__ctor.htm"/>
    public EmbeddingCreateResponse() { }
}
