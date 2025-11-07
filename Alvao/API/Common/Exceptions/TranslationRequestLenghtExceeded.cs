using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationRequestLenghtExceeded.html"/>
public class TranslationRequestLenghtExceeded : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationRequestLenghtExceeded.html#Alvao_API_Common_Exceptions_TranslationRequestLenghtExceeded__ctor"/>
    public TranslationRequestLenghtExceeded() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationRequestLenghtExceeded.html#Alvao_API_Common_Exceptions_TranslationRequestLenghtExceeded__ctor_System_String_"/>
    public TranslationRequestLenghtExceeded(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.TranslationRequestLenghtExceeded.html#Alvao_API_Common_Exceptions_TranslationRequestLenghtExceeded__ctor_System_String_System_Exception_"/>
    public TranslationRequestLenghtExceeded(string message, Exception innerException) { }
}
