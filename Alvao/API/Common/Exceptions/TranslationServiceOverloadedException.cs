using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationServiceOverloadedException.html"/>
public class TranslationServiceOverloadedException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationServiceOverloadedException.html#Alvao_API_Common_Exceptions_TranslationServiceOverloadedException__ctor"/>
    public TranslationServiceOverloadedException() { }
    /// <param name="message"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationServiceOverloadedException.html#Alvao_API_Common_Exceptions_TranslationServiceOverloadedException__ctor_System_String_"/>
    public TranslationServiceOverloadedException(string message) { }
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationServiceOverloadedException.html#Alvao_API_Common_Exceptions_TranslationServiceOverloadedException__ctor_System_String_System_Exception_"/>
    public TranslationServiceOverloadedException(string message, Exception innerException) { }
}
