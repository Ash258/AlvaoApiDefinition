using System.Runtime.Serialization;

namespace Alvao.API.AI.Exceptions;

/// <summary>
/// Thrown when Azure OpenAI returns an error that does not match a more specific known condition (e.g. token rate
/// limiting or maximum context length exceeded). Carries the HTTP status code so callers can inspect the failure
/// without relying on mutable state on the client instance.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.AIRequestException.html"/>
public class AIRequestException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.AIRequestException.html#Alvao_API_AI_Exceptions_AIRequestException_StatusCode"/>
    public int? StatusCode { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.AIRequestException.html#Alvao_API_AI_Exceptions_AIRequestException__ctor"/>
    public AIRequestException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.AIRequestException.html#Alvao_API_AI_Exceptions_AIRequestException__ctor_System_String_"/>
    public AIRequestException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.AIRequestException.html#Alvao_API_AI_Exceptions_AIRequestException__ctor_System_String_System_Exception_"/>
    public AIRequestException(string message, Exception innerException) { }
}
