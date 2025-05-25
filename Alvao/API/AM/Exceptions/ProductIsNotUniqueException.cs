using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ProductIsNotUniqueException.html"/>
public class ProductIsNotUniqueException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ProductIsNotUniqueException.html#Alvao_API_AM_Exceptions_ProductIsNotUniqueException__ctor"/>
    public ProductIsNotUniqueException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ProductIsNotUniqueException.html#Alvao_API_AM_Exceptions_ProductIsNotUniqueException__ctor_System_String_"/>
    public ProductIsNotUniqueException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ProductIsNotUniqueException.html#Alvao_API_AM_Exceptions_ProductIsNotUniqueException__ctor_System_String_System_Exception_"/>
    public ProductIsNotUniqueException(string message, Exception innerException) { }
}
