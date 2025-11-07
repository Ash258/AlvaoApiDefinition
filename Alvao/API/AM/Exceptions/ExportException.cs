using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ExportException.html"/>
public class ExportException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ExportException.html#Alvao_API_AM_Exceptions_ExportException__ctor"/>
    public ExportException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ExportException.html#Alvao_API_AM_Exceptions_ExportException__ctor_System_String_"/>
    public ExportException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ExportException.html#Alvao_API_AM_Exceptions_ExportException__ctor_System_String_System_Exception_"/>
    public ExportException(string message, Exception inner) { }
}
