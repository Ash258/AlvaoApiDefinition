namespace Alvao.API.AM.Exceptions;

public class ProductIsNotUniqueException : Exception
{
    public ProductIsNotUniqueException() { }
    public ProductIsNotUniqueException(
        string message
    )
    { }
    public ProductIsNotUniqueException(
        string message,
        Exception innerException
    )
    { }
}
