using System.Runtime.Serialization;

namespace Alvao.API.AI.Exceptions.ExternalServices;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.ExternalServices.EmbeddingTokensLimitExceededException.html"/>
public class EmbeddingTokensLimitExceededException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.ExternalServices.EmbeddingTokensLimitExceededException.html#Alvao_API_AI_Exceptions_ExternalServices_EmbeddingTokensLimitExceededException__ctor"/>
    public EmbeddingTokensLimitExceededException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.ExternalServices.EmbeddingTokensLimitExceededException.html#Alvao_API_AI_Exceptions_ExternalServices_EmbeddingTokensLimitExceededException__ctor_System_String_"/>
    public EmbeddingTokensLimitExceededException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Exceptions.ExternalServices.EmbeddingTokensLimitExceededException.html#Alvao_API_AI_Exceptions_ExternalServices_EmbeddingTokensLimitExceededException__ctor_System_String_System_Exception_"/>
    public EmbeddingTokensLimitExceededException(string message, Exception innerException) { }
}
