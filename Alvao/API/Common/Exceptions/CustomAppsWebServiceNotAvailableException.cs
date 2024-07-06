namespace Alvao.API.Common.Exceptions;

public class CustomAppsWebServiceNotAvailableException : Exception
{
    public CustomAppsWebServiceNotAvailableException() { }
    public CustomAppsWebServiceNotAvailableException(
        string message
    )
    { }
    public CustomAppsWebServiceNotAvailableException(
        string message,
        Exception innerException
    )
    { }
}
