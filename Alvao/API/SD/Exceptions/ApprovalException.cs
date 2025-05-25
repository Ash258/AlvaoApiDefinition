using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ApprovalException.html"/>
public class ApprovalException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ApprovalException.html#Alvao_API_SD_Exceptions_ApprovalException__ctor"/>
    public ApprovalException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ApprovalException.html#Alvao_API_SD_Exceptions_ApprovalException__ctor_System_String_"/>
    public ApprovalException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.ApprovalException.html#Alvao_API_SD_Exceptions_ApprovalException__ctor_System_String_System_Exception_"/>
    public ApprovalException(string message, Exception inner) { }
}
