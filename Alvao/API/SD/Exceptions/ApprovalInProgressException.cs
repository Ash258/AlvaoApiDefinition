using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ApprovalInProgressException.html"/>
public class ApprovalInProgressException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ApprovalInProgressException.html#Alvao_API_SD_Exceptions_ApprovalInProgressException__ctor"/>
    public ApprovalInProgressException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ApprovalInProgressException.html#Alvao_API_SD_Exceptions_ApprovalInProgressException__ctor_System_String_"/>
    public ApprovalInProgressException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ApprovalInProgressException.html#Alvao_API_SD_Exceptions_ApprovalInProgressException__ctor_System_String_System_Exception_"/>
    public ApprovalInProgressException(string message, Exception inner) { }
}
