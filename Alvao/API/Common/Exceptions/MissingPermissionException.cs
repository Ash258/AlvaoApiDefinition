namespace Alvao.API.Common.Exceptions;

public class MissingPermissionException : Exception
{
    public MissingPermissionException() { }
    public MissingPermissionException(
        string message
    )
    { }
    public MissingPermissionException(
        string message,
        Exception innerException
    )
    { }
}
