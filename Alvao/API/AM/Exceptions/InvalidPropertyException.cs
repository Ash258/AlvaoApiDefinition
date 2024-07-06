namespace Alvao.API.AM.Exceptions;

public class InvalidPropertyException : Exception
{
    public InvalidPropertyException() { }
    public InvalidPropertyException(
        string message
    )
    { }
    public InvalidPropertyException(
        string message,
        Exception innerException
    )
    { }
}
