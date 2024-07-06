namespace Alvao.API.Common.Exceptions;

public class UserTokenServiceError : Exception
{
    public IEnumerable<int> ErrorCodes { get; }

    public UserTokenServiceError() { }
    public UserTokenServiceError(
        string message,
        IEnumerable<int> errorCodes
    )
    { }
    public UserTokenServiceError(
        string message,
        Exception innerException
    )
    { }
}
