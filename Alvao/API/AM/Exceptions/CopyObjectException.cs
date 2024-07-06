namespace Alvao.API.AM.Exceptions;

[SerializableAttribute]
public class CopyObjectException : Exception
{
    public CopyObjectException() { }
    public CopyObjectException(
        string message
    )
    { }
    public CopyObjectException(
        string message,
        Exception innerException
    )
    { }
}
