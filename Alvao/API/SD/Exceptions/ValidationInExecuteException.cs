namespace Alvao.API.SD.Exceptions;

public class ValidationInExecuteException : Exception
{
    public string Field { get; }

    public ValidationInExecuteException() { }
    public ValidationInExecuteException(
        string message
    )
    { }
    public ValidationInExecuteException(
        string message,
        Exception innerException
    )
    { }
    public ValidationInExecuteException(
        string format,
        params Object[] args
    )
    { }
    public ValidationInExecuteException(
        string field,
        string message
    )
    { }
    public ValidationInExecuteException(
        string field,
        string format,
        params Object[] args
    )
    { }
}
