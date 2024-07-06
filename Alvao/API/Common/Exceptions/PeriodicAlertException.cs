namespace Alvao.API.Common.Exceptions;

public class PeriodicAlertException : Exception
{
    public PeriodicAlertException() { }
    public PeriodicAlertException(
        string message
    )
    { }
    public PeriodicAlertException(
        string message,
        Exception innerException
    )
    { }
}
