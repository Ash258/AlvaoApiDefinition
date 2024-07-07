namespace Alvao.API.SD.Exceptions;

public class SlaAccessException : Exception
{
    public SlaAccessException() { }
    public SlaAccessException(
        string message
    )
    { }
    public SlaAccessException(
        string message,
        Exception inner
    )
    { }
}
