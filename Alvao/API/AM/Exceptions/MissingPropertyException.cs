using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.MissingPropertyException.html"/>
public class MissingPropertyException : InvalidPropertyException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.MissingPropertyException.html#Alvao_API_AM_Exceptions_MissingPropertyException__ctor"/>
    public MissingPropertyException() { }
    /// <param name="message"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.MissingPropertyException.html#Alvao_API_AM_Exceptions_MissingPropertyException__ctor_System_String_"/>
    public MissingPropertyException(string message) { }
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.MissingPropertyException.html#Alvao_API_AM_Exceptions_MissingPropertyException__ctor_System_String_System_Exception_"/>
    public MissingPropertyException(string message, Exception innerException) { }
}
