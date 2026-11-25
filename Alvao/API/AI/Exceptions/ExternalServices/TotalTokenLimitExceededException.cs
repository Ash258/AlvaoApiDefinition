using System.Runtime.Serialization;

namespace Alvao.API.AI.Exceptions.ExternalServices;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.ExternalServices.TotalTokenLimitExceededException.html"/>
public class TotalTokenLimitExceededException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.ExternalServices.TotalTokenLimitExceededException.html#Alvao_API_AI_Exceptions_ExternalServices_TotalTokenLimitExceededException__ctor"/>
    public TotalTokenLimitExceededException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.ExternalServices.TotalTokenLimitExceededException.html#Alvao_API_AI_Exceptions_ExternalServices_TotalTokenLimitExceededException__ctor_System_String_"/>
    public TotalTokenLimitExceededException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.ExternalServices.TotalTokenLimitExceededException.html#Alvao_API_AI_Exceptions_ExternalServices_TotalTokenLimitExceededException__ctor_System_String_System_Exception_"/>
    public TotalTokenLimitExceededException(string message, Exception innerException) { }
}
