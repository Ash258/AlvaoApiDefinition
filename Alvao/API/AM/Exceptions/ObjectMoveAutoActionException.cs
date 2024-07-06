namespace Alvao.API.AM.Exceptions;

[SerializableAttribute]
public class ObjectMoveAutoActionException : Exception
{
    public ObjectMoveAutoActionException() { }
    public ObjectMoveAutoActionException(
        string message
    )
    { }
    public ObjectMoveAutoActionException(
        string message,
        Exception innerException
    )
    { }
}
