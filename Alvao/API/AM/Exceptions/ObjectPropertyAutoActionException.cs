namespace Alvao.API.AM.Exceptions;

[SerializableAttribute]
public class ObjectPropertyAutoActionException : Exception
{
    public ObjectPropertyAutoActionException() { }
    public ObjectPropertyAutoActionException(
        string message
    )
    { }
    public ObjectPropertyAutoActionException(
        string message,
        Exception innerException
    )
    { }
}
