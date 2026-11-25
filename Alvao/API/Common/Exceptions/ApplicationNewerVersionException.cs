using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ApplicationNewerVersionException.html"/>
public class ApplicationNewerVersionException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ApplicationNewerVersionException.html#Alvao_API_Common_Exceptions_ApplicationNewerVersionException__ctor"/>
    public ApplicationNewerVersionException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ApplicationNewerVersionException.html#Alvao_API_Common_Exceptions_ApplicationNewerVersionException__ctor_System_String_"/>
    public ApplicationNewerVersionException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ApplicationNewerVersionException.html#Alvao_API_Common_Exceptions_ApplicationNewerVersionException__ctor_System_String_System_Exception_"/>
    public ApplicationNewerVersionException(string message, Exception inner) { }
}
