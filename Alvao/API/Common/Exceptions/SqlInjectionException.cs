using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.SqlInjectionException.html"/>
public class SqlInjectionException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.SqlInjectionException.html#Alvao_API_Common_Exceptions_SqlInjectionException__ctor"/>
    public SqlInjectionException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.SqlInjectionException.html#Alvao_API_Common_Exceptions_SqlInjectionException__ctor_System_String_"/>
    public SqlInjectionException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.SqlInjectionException.html#Alvao_API_Common_Exceptions_SqlInjectionException__ctor_System_String_System_Exception_"/>
    public SqlInjectionException(string message, Exception inner) { }
}
