using System.Runtime.Serialization;

namespace Alvao.API.AI.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.TokenRateException.html"/>
public class TokenRateException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.TokenRateException.html#Alvao_API_AI_Exceptions_TokenRateException_JsonResponse"/>
    public string JsonResponse { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.TokenRateException.html#Alvao_API_AI_Exceptions_TokenRateException__ctor"/>
    public TokenRateException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.TokenRateException.html#Alvao_API_AI_Exceptions_TokenRateException__ctor_System_String_"/>
    public TokenRateException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.TokenRateException.html#Alvao_API_AI_Exceptions_TokenRateException__ctor_System_String_System_Exception_"/>
    public TokenRateException(string message, Exception innerException) { }
}
