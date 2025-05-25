using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.MissingPermissionException.html"/>
public class MissingPermissionException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.MissingPermissionException.html#Alvao_API_Common_Exceptions_MissingPermissionException__ctor"/>
    public MissingPermissionException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.MissingPermissionException.html#Alvao_API_Common_Exceptions_MissingPermissionException__ctor_System_String_"/>
    public MissingPermissionException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.MissingPermissionException.html#Alvao_API_Common_Exceptions_MissingPermissionException__ctor_System_String_System_Exception_"/>
    public MissingPermissionException(string message, Exception innerException) { }
}
