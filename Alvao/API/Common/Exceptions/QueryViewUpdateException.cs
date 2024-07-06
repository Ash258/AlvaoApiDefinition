namespace Alvao.API.Common.Exceptions;

public class QueryViewUpdateException : Exception
{
    public QueryViewUpdateException() { }
    public QueryViewUpdateException(
        string message
    )
    { }
    public QueryViewUpdateException(
        string message,
        Exception innerException
    )
    { }
}
