namespace Alvao.API.Common.Exceptions;

public class SqlInjectionException : Exception
{
    public SqlInjectionException() { }
    public SqlInjectionException(
        string message
    )
    { }
    public SqlInjectionException(
        string message,
        Exception inner
    )
    { }
}
