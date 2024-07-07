namespace Alvao.API.SD.Exceptions;

public class TicketApprovalNotInProgressException : Exception
{
    public TicketApprovalNotInProgressException() { }
    public TicketApprovalNotInProgressException(
        string message
    )
    { }
    public TicketApprovalNotInProgressException(
        string message,
        Exception inner
    )
    { }
}
