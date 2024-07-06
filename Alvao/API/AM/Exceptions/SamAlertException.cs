namespace Alvao.API.AM.Exceptions;

public class SamAlertException : Exception
{
    public SamAlertException() { }
    public SamAlertException(
        string message
    )
    { }
    public SamAlertException(
        string message,
        Exception innerException
    )
    { }
}
