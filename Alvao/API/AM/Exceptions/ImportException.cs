using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ImportException.html"/>
public class ImportException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ImportException.html#Alvao_API_AM_Exceptions_ImportException__ctor"/>
    public ImportException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ImportException.html#Alvao_API_AM_Exceptions_ImportException__ctor_System_String_"/>
    public ImportException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ImportException.html#Alvao_API_AM_Exceptions_ImportException__ctor_System_String_System_Exception_"/>
    public ImportException(string message, Exception inner) { }
}
