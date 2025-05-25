using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.TeamsNotificationException.html"/>
public class TeamsNotificationException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.TeamsNotificationException.html#Alvao_API_SD_Exceptions_TeamsNotificationException__ctor"/>
    public TeamsNotificationException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.TeamsNotificationException.html#Alvao_API_SD_Exceptions_TeamsNotificationException__ctor_System_String_"/>
    public TeamsNotificationException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.TeamsNotificationException.html#Alvao_API_SD_Exceptions_TeamsNotificationException__ctor_System_String_System_Exception_"/>
    public TeamsNotificationException(string message, Exception innerException) { }
}
