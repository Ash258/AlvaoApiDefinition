using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationException.html"/>
public class ValidationException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationException.html#Alvao_API_SD_Exceptions_ValidationException_Field"/>
    public string Field { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationException.html#Alvao_API_SD_Exceptions_ValidationException__ctor"/>
    public ValidationException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationException.html#Alvao_API_SD_Exceptions_ValidationException__ctor_System_String_"/>
    public ValidationException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationException.html#Alvao_API_SD_Exceptions_ValidationException__ctor_System_String_System_Exception_"/>
    public ValidationException(string message, Exception innerException) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationException.html#Alvao_API_SD_Exceptions_ValidationException__ctor_System_String_System_Object___"/>
    public ValidationException(string format, params object[] args) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationException.html#Alvao_API_SD_Exceptions_ValidationException__ctor_System_String_System_String_"/>
    public ValidationException(string field, string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationException.html#Alvao_API_SD_Exceptions_ValidationException__ctor_System_String_System_String_System_Object___"/>
    public ValidationException(string field, string format, params object[] args) { }
}
