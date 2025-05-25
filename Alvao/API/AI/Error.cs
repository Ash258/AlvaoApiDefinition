using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Error.html"/>
public class Error {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Error.html#Alvao_API_AI_Error_Code"/>
    [JsonProperty("code")]
    public string Code { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Error.html#Alvao_API_AI_Error_Message"/>
    [JsonProperty("message")]
    public string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Error.html#Alvao_API_AI_Error_Param"/>
    [JsonProperty("param")]
    public string Param { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Error.html#Alvao_API_AI_Error_Type"/>
    [JsonProperty("type")]
    public string Type { get; set; }
}
