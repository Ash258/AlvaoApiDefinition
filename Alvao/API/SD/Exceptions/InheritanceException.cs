namespace Alvao.API.SD.Exceptions;

public class InheritanceException : Exception
{
    public InheritanceException() { }
    public InheritanceException(
        string message
    )
    { }
    public InheritanceException(
        string message,
        Exception inner
    )
    { }
}
