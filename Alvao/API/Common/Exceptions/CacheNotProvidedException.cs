using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.CacheNotProvidedException.html"/>
public class CacheNotProvidedException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.CacheNotProvidedException.html#Alvao_API_Common_Exceptions_CacheNotProvidedException__ctor"/>
    public CacheNotProvidedException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.CacheNotProvidedException.html#Alvao_API_Common_Exceptions_CacheNotProvidedException__ctor_System_String_"/>
    public CacheNotProvidedException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.CacheNotProvidedException.html#Alvao_API_Common_Exceptions_CacheNotProvidedException__ctor_System_String_System_Exception_"/>
    public CacheNotProvidedException(string message, Exception innerException) { }
}
