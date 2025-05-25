using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectNotFoundException.html"/>
public class ObjectNotFoundException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectNotFoundException.html#Alvao_API_AM_Exceptions_ObjectNotFoundException__ctor"/>
    public ObjectNotFoundException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectNotFoundException.html#Alvao_API_AM_Exceptions_ObjectNotFoundException__ctor_System_String_"/>
    public ObjectNotFoundException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectNotFoundException.html#Alvao_API_AM_Exceptions_ObjectNotFoundException__ctor_System_String_System_Exception_"/>
    public ObjectNotFoundException(string message, Exception innerException) { }
}
