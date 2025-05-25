using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.HandoverProtocolNotificationException.html"/>
public class HandoverProtocolNotificationException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.HandoverProtocolNotificationException.html#Alvao_API_AM_Exceptions_HandoverProtocolNotificationException__ctor"/>
    public HandoverProtocolNotificationException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.HandoverProtocolNotificationException.html#Alvao_API_AM_Exceptions_HandoverProtocolNotificationException__ctor_System_String_"/>
    public HandoverProtocolNotificationException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.HandoverProtocolNotificationException.html#Alvao_API_AM_Exceptions_HandoverProtocolNotificationException__ctor_System_String_System_Exception_"/>
    public HandoverProtocolNotificationException(string message, Exception innerException) { }
}
