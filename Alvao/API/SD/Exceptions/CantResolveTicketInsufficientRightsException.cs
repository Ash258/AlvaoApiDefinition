using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Exceptions_CantResolveTicketInsufficientRightsException.htm"/>
public class CantResolveTicketInsufficientRightsException : Exception {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_CantResolveTicketInsufficientRightsException__ctor.htm"/>
    public CantResolveTicketInsufficientRightsException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_CantResolveTicketInsufficientRightsException__ctor_2.htm"/>
    public CantResolveTicketInsufficientRightsException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_CantResolveTicketInsufficientRightsException__ctor_1.htm"/>
    public CantResolveTicketInsufficientRightsException(
        SerializationInfo info,
        StreamingContext context
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_CantResolveTicketInsufficientRightsException__ctor_3.htm"/>
    public CantResolveTicketInsufficientRightsException(
        string message,
        Exception inner
    ) { }
}
