using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectPropertyAutoActionException.html"/>
[Serializable]
public class ObjectPropertyAutoActionException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectPropertyAutoActionException.html#Alvao_API_AM_Exceptions_ObjectPropertyAutoActionException__ctor"/>
    public ObjectPropertyAutoActionException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectPropertyAutoActionException.html#Alvao_API_AM_Exceptions_ObjectPropertyAutoActionException__ctor_System_String_"/>
    public ObjectPropertyAutoActionException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectPropertyAutoActionException.html#Alvao_API_AM_Exceptions_ObjectPropertyAutoActionException__ctor_System_String_System_Exception_"/>
    public ObjectPropertyAutoActionException(string message, Exception innerException) { }
}
