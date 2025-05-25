using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidMoveException.html"/>
[Serializable]
public class InvalidMoveException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidMoveException.html#Alvao_API_AM_Exceptions_InvalidMoveException_FailedObjectIds"/>
    public IEnumerable<int> FailedObjectIds { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidMoveException.html#Alvao_API_AM_Exceptions_InvalidMoveException__ctor"/>
    public InvalidMoveException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidMoveException.html#Alvao_API_AM_Exceptions_InvalidMoveException__ctor_System_String_"/>
    public InvalidMoveException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidMoveException.html#Alvao_API_AM_Exceptions_InvalidMoveException__ctor_System_String_System_Exception_"/>
    public InvalidMoveException(string message, Exception innerException) { }
}
