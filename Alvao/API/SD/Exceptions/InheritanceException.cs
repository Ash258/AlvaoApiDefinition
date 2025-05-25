using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.InheritanceException.html"/>
public class InheritanceException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.InheritanceException.html#Alvao_API_SD_Exceptions_InheritanceException__ctor"/>
    public InheritanceException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.InheritanceException.html#Alvao_API_SD_Exceptions_InheritanceException__ctor_System_String_"/>
    public InheritanceException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.InheritanceException.html#Alvao_API_SD_Exceptions_InheritanceException__ctor_System_String_System_Exception_"/>
    public InheritanceException(string message, Exception inner) { }
}
