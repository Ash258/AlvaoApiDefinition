using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.CabinetOperationFailed.html"/>
public class CabinetOperationFailed : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.CabinetOperationFailed.html#Alvao_API_AM_Exceptions_CabinetOperationFailed__ctor"/>
    public CabinetOperationFailed() { }
    /// <param name="message"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.CabinetOperationFailed.html#Alvao_API_AM_Exceptions_CabinetOperationFailed__ctor_System_String_"/>
    public CabinetOperationFailed(string message) { }
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.CabinetOperationFailed.html#Alvao_API_AM_Exceptions_CabinetOperationFailed__ctor_System_String_System_Exception_"/>
    public CabinetOperationFailed(string message, Exception innerException) { }
}
