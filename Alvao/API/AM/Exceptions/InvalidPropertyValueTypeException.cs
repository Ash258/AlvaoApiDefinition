using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyValueTypeException.html"/>
public class InvalidPropertyValueTypeException : InvalidPropertyException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyValueTypeException.html#Alvao_API_AM_Exceptions_InvalidPropertyValueTypeException__ctor"/>
    public InvalidPropertyValueTypeException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyValueTypeException.html#Alvao_API_AM_Exceptions_InvalidPropertyValueTypeException__ctor_System_String_"/>
    public InvalidPropertyValueTypeException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyValueTypeException.html#Alvao_API_AM_Exceptions_InvalidPropertyValueTypeException__ctor_System_String_System_Exception_"/>
    public InvalidPropertyValueTypeException(string message, Exception innerException) { }
}
