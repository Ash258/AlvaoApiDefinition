using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.BackResolveException.html"/>
public class BackResolveException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.BackResolveException.html#Alvao_API_SD_Exceptions_BackResolveException__ctor"/>
    public BackResolveException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.BackResolveException.html#Alvao_API_SD_Exceptions_BackResolveException__ctor_System_String_"/>
    public BackResolveException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.BackResolveException.html#Alvao_API_SD_Exceptions_BackResolveException__ctor_System_String_System_Exception_"/>
    public BackResolveException(string message, Exception inner) { }
}
