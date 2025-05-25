using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkMoveException.html"/>
[Serializable]
public class InvalidBulkMoveException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkMoveException.html#Alvao_API_AM_Exceptions_InvalidBulkMoveException_FailedObjectIds"/>
    public IEnumerable<int> FailedObjectIds { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkMoveException.html#Alvao_API_AM_Exceptions_InvalidBulkMoveException__ctor"/>
    public InvalidBulkMoveException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkMoveException.html#Alvao_API_AM_Exceptions_InvalidBulkMoveException__ctor_System_String_"/>
    public InvalidBulkMoveException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkMoveException.html#Alvao_API_AM_Exceptions_InvalidBulkMoveException__ctor_System_String_System_Exception_"/>
    public InvalidBulkMoveException(string message, Exception innerException) { }
}
