namespace Alvao.API.SD.Exceptions;

public class ApprovalException : Exception
{
    public ApprovalException() { }
    public ApprovalException(
        string message
    )
    { }
    public ApprovalException(
        string message,
        Exception inner
    )
    { }
}
