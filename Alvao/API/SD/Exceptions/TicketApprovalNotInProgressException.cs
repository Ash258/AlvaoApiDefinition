using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.TicketApprovalNotInProgressException.html"/>
public class TicketApprovalNotInProgressException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.TicketApprovalNotInProgressException.html#Alvao_API_SD_Exceptions_TicketApprovalNotInProgressException__ctor"/>
    public TicketApprovalNotInProgressException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.TicketApprovalNotInProgressException.html#Alvao_API_SD_Exceptions_TicketApprovalNotInProgressException__ctor_System_String_"/>
    public TicketApprovalNotInProgressException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.TicketApprovalNotInProgressException.html#Alvao_API_SD_Exceptions_TicketApprovalNotInProgressException__ctor_System_String_System_Exception_"/>
    public TicketApprovalNotInProgressException(string message, Exception inner) { }
}
