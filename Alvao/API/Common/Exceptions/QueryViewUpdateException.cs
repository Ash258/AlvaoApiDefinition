using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.QueryViewUpdateException.html"/>
public class QueryViewUpdateException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.QueryViewUpdateException.html#Alvao_API_Common_Exceptions_QueryViewUpdateException__ctor"/>
    public QueryViewUpdateException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.QueryViewUpdateException.html#Alvao_API_Common_Exceptions_QueryViewUpdateException__ctor_System_String_"/>
    public QueryViewUpdateException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.QueryViewUpdateException.html#Alvao_API_Common_Exceptions_QueryViewUpdateException__ctor_System_String_System_Exception_"/>
    public QueryViewUpdateException(string message, Exception innerException) { }
}
