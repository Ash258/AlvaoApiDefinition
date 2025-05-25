using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.MissingSenderException.html"/>
public class MissingSenderException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.MissingSenderException.html#Alvao_API_Common_Exceptions_MissingSenderException__ctor"/>
    public MissingSenderException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.MissingSenderException.html#Alvao_API_Common_Exceptions_MissingSenderException__ctor_System_String_"/>
    public MissingSenderException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.MissingSenderException.html#Alvao_API_Common_Exceptions_MissingSenderException__ctor_System_String_System_Exception_"/>
    public MissingSenderException(string message, Exception innerException) { }
}
