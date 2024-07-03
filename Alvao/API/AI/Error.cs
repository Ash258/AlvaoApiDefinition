using Newtonsoft.Json;

namespace Alvao.API.AI;

public class Error
{
    [JsonPropertyAttribute("code")]
    public string Code { get; set; }
    [JsonPropertyAttribute("message")]
    public string Message { get; set; }
    [JsonPropertyAttribute("param")]
    public string Param { get; set; }
    [JsonPropertyAttribute("type")]
    public string Type { get; set; }
}
