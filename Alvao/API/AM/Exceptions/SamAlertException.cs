using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.SamAlertException.html"/>
public class SamAlertException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.SamAlertException.html#Alvao_API_AM_Exceptions_SamAlertException__ctor"/>
    public SamAlertException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.SamAlertException.html#Alvao_API_AM_Exceptions_SamAlertException__ctor_System_String_"/>
    public SamAlertException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.SamAlertException.html#Alvao_API_AM_Exceptions_SamAlertException__ctor_System_String_System_Exception_"/>
    public SamAlertException(string message, Exception innerException) { }
}
