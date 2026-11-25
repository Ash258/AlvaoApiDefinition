using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.JsonDecompressOperationFailed.html"/>
public class JsonDecompressOperationFailed : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.JsonDecompressOperationFailed.html#Alvao_API_AM_Exceptions_JsonDecompressOperationFailed__ctor"/>
    public JsonDecompressOperationFailed() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.JsonDecompressOperationFailed.html#Alvao_API_AM_Exceptions_JsonDecompressOperationFailed__ctor_System_String_"/>
    public JsonDecompressOperationFailed(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.JsonDecompressOperationFailed.html#Alvao_API_AM_Exceptions_JsonDecompressOperationFailed__ctor_System_String_System_Exception_"/>
    public JsonDecompressOperationFailed(string message, Exception innerException) { }
}
