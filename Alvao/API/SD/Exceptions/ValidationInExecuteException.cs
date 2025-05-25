using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationInExecuteException.html"/>
public class ValidationInExecuteException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationInExecuteException.html#Alvao_API_SD_Exceptions_ValidationInExecuteException_Field"/>
    public string Field { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationInExecuteException.html#Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor"/>
    public ValidationInExecuteException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationInExecuteException.html#Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_System_String_"/>
    public ValidationInExecuteException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationInExecuteException.html#Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_System_String_System_Exception_"/>
    public ValidationInExecuteException(string message, Exception innerException) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationInExecuteException.html#Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_System_String_System_Object___"/>
    public ValidationInExecuteException(string format, params object[] args) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationInExecuteException.html#Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_System_String_System_String_"/>
    public ValidationInExecuteException(string field, string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ValidationInExecuteException.html#Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_System_String_System_String_System_Object___"/>
    public ValidationInExecuteException(string field, string format, params object[] args) { }
}
