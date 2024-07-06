namespace Alvao.API.AM.Exceptions;

[SerializableAttribute]
public class UnauthorizedObjectOperationEception : Exception
{
    public UnauthorizedObjectOperationEception() { }
    public UnauthorizedObjectOperationEception(
        string message
    )
    { }
    public UnauthorizedObjectOperationEception(
        string message,
        Exception innerException
    )
    { }
}
