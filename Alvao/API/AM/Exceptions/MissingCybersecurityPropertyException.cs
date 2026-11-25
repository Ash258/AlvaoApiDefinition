using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.MissingCybersecurityPropertyException.html"/>
public class MissingCybersecurityPropertyException : InvalidPropertyException, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.MissingCybersecurityPropertyException.html#Alvao_API_AM_Exceptions_MissingCybersecurityPropertyException__ctor"/>
    public MissingCybersecurityPropertyException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.MissingCybersecurityPropertyException.html#Alvao_API_AM_Exceptions_MissingCybersecurityPropertyException__ctor_System_String_"/>
    public MissingCybersecurityPropertyException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.MissingCybersecurityPropertyException.html#Alvao_API_AM_Exceptions_MissingCybersecurityPropertyException__ctor_System_String_System_Exception_"/>
    public MissingCybersecurityPropertyException(string message, Exception innerException) { }
}
