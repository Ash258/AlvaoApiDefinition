namespace Alvao.API.SD.Exceptions;

public class ValidationException : Exception
{
    public string Field { get; }

    public ValidationException() { }
    public ValidationException(
        string message
    )
    { }
    public ValidationException(
        string message,
        Exception innerException
    )
    { }
    public ValidationException(
        string format,
        params Object[] args
    )
    { }
    public ValidationException(
        string field,
        string message
    )
    { }
    public ValidationException(
        string field,
        string format,
        params Object[] args
    )
    { }
}
