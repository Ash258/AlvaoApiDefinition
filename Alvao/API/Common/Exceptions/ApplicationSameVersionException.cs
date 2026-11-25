using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ApplicationSameVersionException.html"/>
public class ApplicationSameVersionException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ApplicationSameVersionException.html#Alvao_API_Common_Exceptions_ApplicationSameVersionException__ctor"/>
    public ApplicationSameVersionException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ApplicationSameVersionException.html#Alvao_API_Common_Exceptions_ApplicationSameVersionException__ctor_System_String_"/>
    public ApplicationSameVersionException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ApplicationSameVersionException.html#Alvao_API_Common_Exceptions_ApplicationSameVersionException__ctor_System_String_System_Exception_"/>
    public ApplicationSameVersionException(string message, Exception inner) { }
}
