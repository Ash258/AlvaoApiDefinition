using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InheritedOrFromExternalSourcePropertyException.html"/>
public class InheritedOrFromExternalSourcePropertyException : InvalidPropertyException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InheritedOrFromExternalSourcePropertyException.html#Alvao_API_AM_Exceptions_InheritedOrFromExternalSourcePropertyException__ctor"/>
    public InheritedOrFromExternalSourcePropertyException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InheritedOrFromExternalSourcePropertyException.html#Alvao_API_AM_Exceptions_InheritedOrFromExternalSourcePropertyException__ctor_System_String_"/>
    public InheritedOrFromExternalSourcePropertyException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InheritedOrFromExternalSourcePropertyException.html#Alvao_API_AM_Exceptions_InheritedOrFromExternalSourcePropertyException__ctor_System_String_System_Exception_"/>
    public InheritedOrFromExternalSourcePropertyException(string message, Exception innerException) { }
}
