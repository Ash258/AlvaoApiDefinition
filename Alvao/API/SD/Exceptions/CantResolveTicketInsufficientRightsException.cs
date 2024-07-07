using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

public class CantResolveTicketInsufficientRightsException : Exception
{
    public CantResolveTicketInsufficientRightsException() { }
    public CantResolveTicketInsufficientRightsException(
        string message
    )
    { }
    public CantResolveTicketInsufficientRightsException(
        SerializationInfo info,
        StreamingContext context
    )
    { }
    public CantResolveTicketInsufficientRightsException(
        string message,
        Exception inner
    )
    { }
}
