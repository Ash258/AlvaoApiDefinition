using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.BaseResponse.html"/>
public class BaseResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.BaseResponse.html#Alvao_API_AI_BaseResponse_Error"/>
    [JsonProperty("error")]
    public Error Error { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.BaseResponse.html#Alvao_API_AI_BaseResponse_ObjectTypeName"/>
    [JsonProperty("object")]
    public string ObjectTypeName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.BaseResponse.html#Alvao_API_AI_BaseResponse_Successful"/>
    public bool Successful { get; }
}
