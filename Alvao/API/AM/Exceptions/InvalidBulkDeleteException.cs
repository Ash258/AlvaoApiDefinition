using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkDeleteException.html"/>
[Serializable]
public class InvalidBulkDeleteException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkDeleteException.html#Alvao_API_AM_Exceptions_InvalidBulkDeleteException_FailedObjectIds"/>
    public IEnumerable<int> FailedObjectIds { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkDeleteException.html#Alvao_API_AM_Exceptions_InvalidBulkDeleteException__ctor"/>
    public InvalidBulkDeleteException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkDeleteException.html#Alvao_API_AM_Exceptions_InvalidBulkDeleteException__ctor_System_String_"/>
    public InvalidBulkDeleteException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.InvalidBulkDeleteException.html#Alvao_API_AM_Exceptions_InvalidBulkDeleteException__ctor_System_String_System_Exception_"/>
    public InvalidBulkDeleteException(string message, Exception innerException) { }
}
