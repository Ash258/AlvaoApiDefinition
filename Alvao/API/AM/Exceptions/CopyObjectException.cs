using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.CopyObjectException.html"/>
[Serializable]
public class CopyObjectException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.CopyObjectException.html#Alvao_API_AM_Exceptions_CopyObjectException__ctor"/>
    public CopyObjectException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.CopyObjectException.html#Alvao_API_AM_Exceptions_CopyObjectException__ctor_System_String_"/>
    public CopyObjectException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.CopyObjectException.html#Alvao_API_AM_Exceptions_CopyObjectException__ctor_System_String_System_Exception_"/>
    public CopyObjectException(string message, Exception innerException) { }
}
