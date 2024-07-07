namespace Alvao.API.SD.Exceptions;

public class TeamsNotificationException : Exception
{
    public TeamsNotificationException() { }
    public TeamsNotificationException(
        string message
    )
    { }
    public TeamsNotificationException(
        string message,
        Exception innerException
    )
    { }
}
