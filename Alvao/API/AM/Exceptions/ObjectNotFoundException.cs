namespace Alvao.API.AM.Exceptions;

public class ObjectNotFoundException : Exception
{
    public ObjectNotFoundException() { }
    public ObjectNotFoundException(
        string message
    )
    { }
    public ObjectNotFoundException(
        string message,
        Exception innerException
    )
    { }
}
