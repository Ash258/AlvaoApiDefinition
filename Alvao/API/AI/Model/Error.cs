using Newtonsoft.Json;

namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.Error.html"/>
public class Error {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.Error.html#Alvao_API_AI_Model_Error_Code"/>
    [JsonProperty("code")]
    public string Code { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.Error.html#Alvao_API_AI_Model_Error_Message"/>
    [JsonProperty("message")]
    public string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.Error.html#Alvao_API_AI_Model_Error_Param"/>
    [JsonProperty("param")]
    public string Param { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.Error.html#Alvao_API_AI_Model_Error_Type"/>
    [JsonProperty("type")]
    public string Type { get; set; }
}
