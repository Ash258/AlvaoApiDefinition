namespace Alvao.API.AM.Exceptions;

public class InvalidPropertyValueTypeException : InvalidPropertyException
{
    public InvalidPropertyValueTypeException() { }
    public InvalidPropertyValueTypeException(
        string message
    )
    { }
    public InvalidPropertyValueTypeException(
        string message,
        Exception innerException
    )
    { }
}
