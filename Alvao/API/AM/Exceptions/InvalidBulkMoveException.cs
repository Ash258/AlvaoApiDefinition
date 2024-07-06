using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

[SerializableAttribute]
public class InvalidBulkMoveException : Exception
{
    public InvalidBulkMoveException() { }
    public InvalidBulkMoveException(
        string message
    )
    { }
    public InvalidBulkMoveException(
        SerializationInfo info,
        StreamingContext context
    )
    { }
    public InvalidBulkMoveException(
        string message,
        Exception innerException
    )
    { }
}
