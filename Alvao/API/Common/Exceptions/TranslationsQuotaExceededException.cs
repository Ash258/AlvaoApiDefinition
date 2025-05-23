using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationsQuotaExceededException.html"/>
public class TranslationsQuotaExceededException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationsQuotaExceededException.html#Alvao_API_Common_Exceptions_TranslationsQuotaExceededException__ctor"/>
    public TranslationsQuotaExceededException() { }
    /// <param name="message"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationsQuotaExceededException.html#Alvao_API_Common_Exceptions_TranslationsQuotaExceededException__ctor_System_String_"/>
    public TranslationsQuotaExceededException(string message) { }
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationsQuotaExceededException.html#Alvao_API_Common_Exceptions_TranslationsQuotaExceededException__ctor_System_String_System_Exception_"/>
    public TranslationsQuotaExceededException(string message, Exception innerException) { }
}
