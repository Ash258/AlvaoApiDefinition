using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

[SerializableAttribute]
public class InvalidMoveException : Exception
{
    public InvalidMoveException() { }
    public InvalidMoveException(
        string message
    )
    { }
    public InvalidMoveException(
        SerializationInfo info,
        StreamingContext context
    )
    { }
    public InvalidMoveException(
        string message,
        Exception innerException
    )
    { }
}
