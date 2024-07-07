using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

public class BackResolveException : Exception
{
    public BackResolveException() { }
    public BackResolveException(
        string message
    )
    { }
    public BackResolveException(
        SerializationInfo info,
        StreamingContext context
    )
    { }
    public BackResolveException(
        string message,
        Exception inner
    )
    { }
}
