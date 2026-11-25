using System.Runtime.Serialization;

namespace Alvao.API.AI.Exceptions;

/// <summary>
/// Thrown when Azure OpenAI rejects a request because the input exceeds the model's maximum context length, so callers
/// can truncate the input and retry.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.MaxContextLengthExceededException.html"/>
public class MaxContextLengthExceededException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.MaxContextLengthExceededException.html#Alvao_API_AI_Exceptions_MaxContextLengthExceededException__ctor"/>
    public MaxContextLengthExceededException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.MaxContextLengthExceededException.html#Alvao_API_AI_Exceptions_MaxContextLengthExceededException__ctor_System_String_"/>
    public MaxContextLengthExceededException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.MaxContextLengthExceededException.html#Alvao_API_AI_Exceptions_MaxContextLengthExceededException__ctor_System_String_System_Exception_"/>
    public MaxContextLengthExceededException(string message, Exception innerException) { }
}
