using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.SlaAccessException.html"/>
public class SlaAccessException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.SlaAccessException.html#Alvao_API_SD_Exceptions_SlaAccessException__ctor"/>
    public SlaAccessException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.SlaAccessException.html#Alvao_API_SD_Exceptions_SlaAccessException__ctor_System_String_"/>
    public SlaAccessException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.SlaAccessException.html#Alvao_API_SD_Exceptions_SlaAccessException__ctor_System_String_System_Exception_"/>
    public SlaAccessException(string message, Exception inner) { }
}
