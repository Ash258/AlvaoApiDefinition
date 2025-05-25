using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyException.html"/>
public class InvalidPropertyException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyException.html#Alvao_API_AM_Exceptions_InvalidPropertyException__ctor"/>
    public InvalidPropertyException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyException.html#Alvao_API_AM_Exceptions_InvalidPropertyException__ctor_System_String_"/>
    public InvalidPropertyException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidPropertyException.html#Alvao_API_AM_Exceptions_InvalidPropertyException__ctor_System_String_System_Exception_"/>
    public InvalidPropertyException(string message, Exception innerException) { }
}
