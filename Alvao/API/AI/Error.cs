using Newtonsoft.Json;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_Error.htm"/>
public class Error
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Error_Code.htm"/>
    [JsonPropertyAttribute("code")]
    public string Code { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Error_Message.htm"/>
    [JsonPropertyAttribute("message")]
    public string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Error_Param.htm"/>
    [JsonPropertyAttribute("param")]
    public string Param { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Error_Type.htm"/>
    [JsonPropertyAttribute("type")]
    public string Type { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Error__ctor.htm"/>
    public Error() { }
}
