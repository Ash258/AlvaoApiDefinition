using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.CantResolveTicketInsufficientRightsException.html"/>
public class CantResolveTicketInsufficientRightsException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.CantResolveTicketInsufficientRightsException.html#Alvao_API_SD_Exceptions_CantResolveTicketInsufficientRightsException__ctor"/>
    public CantResolveTicketInsufficientRightsException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.CantResolveTicketInsufficientRightsException.html#Alvao_API_SD_Exceptions_CantResolveTicketInsufficientRightsException__ctor_System_String_"/>
    public CantResolveTicketInsufficientRightsException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.CantResolveTicketInsufficientRightsException.html#Alvao_API_SD_Exceptions_CantResolveTicketInsufficientRightsException__ctor_System_String_System_Exception_"/>
    public CantResolveTicketInsufficientRightsException(string message, Exception inner) { }
}
