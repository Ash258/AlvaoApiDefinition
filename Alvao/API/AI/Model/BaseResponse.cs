using Newtonsoft.Json;

namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.BaseResponse.html"/>
public class BaseResponse {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.BaseResponse.html#Alvao_API_AI_Model_BaseResponse_Error"/>
    [JsonProperty("error")]
    public Error Error { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.BaseResponse.html#Alvao_API_AI_Model_BaseResponse_ObjectTypeName"/>
    [JsonProperty("object")]
    public string ObjectTypeName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.BaseResponse.html#Alvao_API_AI_Model_BaseResponse_Successful"/>
    public bool Successful { get; }
}
