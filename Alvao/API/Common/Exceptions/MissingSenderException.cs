namespace Alvao.API.Common.Exceptions;

public class MissingSenderException : Exception
{
    public MissingSenderException() { }
    public MissingSenderException(
        string message
    )
    { }
    public MissingSenderException(
        string message,
        Exception innerException
    )
    { }
}
