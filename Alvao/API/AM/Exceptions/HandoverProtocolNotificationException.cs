namespace Alvao.API.AM.Exceptions;

public class HandoverProtocolNotificationException : Exception
{
    public HandoverProtocolNotificationException() { }
    public HandoverProtocolNotificationException(
        string message
    )
    { }
    public HandoverProtocolNotificationException(
        string message,
        Exception innerException
    )
    { }
}
