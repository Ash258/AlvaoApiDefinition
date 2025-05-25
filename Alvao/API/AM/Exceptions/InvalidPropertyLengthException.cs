using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyLengthException.html"/>
public class InvalidPropertyLengthException : InvalidPropertyException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyLengthException.html#Alvao_API_AM_Exceptions_InvalidPropertyLengthException__ctor"/>
    public InvalidPropertyLengthException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyLengthException.html#Alvao_API_AM_Exceptions_InvalidPropertyLengthException__ctor_System_String_"/>
    public InvalidPropertyLengthException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyLengthException.html#Alvao_API_AM_Exceptions_InvalidPropertyLengthException__ctor_System_String_System_Exception_"/>
    public InvalidPropertyLengthException(string message, Exception innerException) { }
}
