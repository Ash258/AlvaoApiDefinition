using Newtonsoft.Json;

namespace Alvao.API.AI;

public class BaseResponse
{
    [JsonPropertyAttribute("error")]
    public Error Error { get; set; }
    [JsonPropertyAttribute("object")]
    public string ObjectTypeName { get; set; }
    public bool Successful { get; }
}
