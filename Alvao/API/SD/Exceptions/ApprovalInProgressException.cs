namespace Alvao.API.SD.Exceptions;

public class ApprovalInProgressException : Exception
{
    public ApprovalInProgressException() { }
    public ApprovalInProgressException(
        string message
    )
    { }
    public ApprovalInProgressException(
        string message,
        Exception inner
    )
    { }
}
