namespace Alvao.API.Common.Exceptions;

public class CacheNotProvidedException : Exception
{
    public CacheNotProvidedException() { }
    public CacheNotProvidedException(
        string message
    )
    { }
    public CacheNotProvidedException(
        string message,
        Exception innerException
    )
    { }
}
