using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.UnauthorizedObjectOperationException.html"/>
[Serializable]
public class UnauthorizedObjectOperationException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.UnauthorizedObjectOperationException.html#Alvao_API_AM_Exceptions_UnauthorizedObjectOperationException__ctor"/>
    public UnauthorizedObjectOperationException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.UnauthorizedObjectOperationException.html#Alvao_API_AM_Exceptions_UnauthorizedObjectOperationException__ctor_System_String_"/>
    public UnauthorizedObjectOperationException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.UnauthorizedObjectOperationException.html#Alvao_API_AM_Exceptions_UnauthorizedObjectOperationException__ctor_System_String_System_Exception_"/>
    public UnauthorizedObjectOperationException(string message, Exception innerException) { }
}
