using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.UnauthorizedObjectOperationEception.html"/>
[Serializable]
public class UnauthorizedObjectOperationEception : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.UnauthorizedObjectOperationEception.html#Alvao_API_AM_Exceptions_UnauthorizedObjectOperationEception__ctor"/>
    public UnauthorizedObjectOperationEception() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.UnauthorizedObjectOperationEception.html#Alvao_API_AM_Exceptions_UnauthorizedObjectOperationEception__ctor_System_String_"/>
    public UnauthorizedObjectOperationEception(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.UnauthorizedObjectOperationEception.html#Alvao_API_AM_Exceptions_UnauthorizedObjectOperationEception__ctor_System_String_System_Exception_"/>
    public UnauthorizedObjectOperationEception(string message, Exception innerException) { }
}
