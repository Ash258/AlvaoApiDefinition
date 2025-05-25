using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationsSecretsInvalidException.html"/>
public class TranslationsSecretsInvalidException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationsSecretsInvalidException.html#Alvao_API_Common_Exceptions_TranslationsSecretsInvalidException__ctor"/>
    public TranslationsSecretsInvalidException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationsSecretsInvalidException.html#Alvao_API_Common_Exceptions_TranslationsSecretsInvalidException__ctor_System_String_"/>
    public TranslationsSecretsInvalidException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationsSecretsInvalidException.html#Alvao_API_Common_Exceptions_TranslationsSecretsInvalidException__ctor_System_String_System_Exception_"/>
    public TranslationsSecretsInvalidException(string message, Exception innerException) { }
}
