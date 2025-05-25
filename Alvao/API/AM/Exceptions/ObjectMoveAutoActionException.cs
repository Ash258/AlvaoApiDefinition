using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectMoveAutoActionException.html"/>
[Serializable]
public class ObjectMoveAutoActionException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectMoveAutoActionException.html#Alvao_API_AM_Exceptions_ObjectMoveAutoActionException_FailedObjectIds"/>
    public IEnumerable<int> FailedObjectIds { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectMoveAutoActionException.html#Alvao_API_AM_Exceptions_ObjectMoveAutoActionException__ctor"/>
    public ObjectMoveAutoActionException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectMoveAutoActionException.html#Alvao_API_AM_Exceptions_ObjectMoveAutoActionException__ctor_System_String_"/>
    public ObjectMoveAutoActionException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectMoveAutoActionException.html#Alvao_API_AM_Exceptions_ObjectMoveAutoActionException__ctor_System_String_System_Exception_"/>
    public ObjectMoveAutoActionException(string message, Exception innerException) { }
}
