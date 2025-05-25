using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.PeriodicAlertException.html"/>
public class PeriodicAlertException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.PeriodicAlertException.html#Alvao_API_Common_Exceptions_PeriodicAlertException__ctor"/>
    public PeriodicAlertException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.PeriodicAlertException.html#Alvao_API_Common_Exceptions_PeriodicAlertException__ctor_System_String_"/>
    public PeriodicAlertException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.PeriodicAlertException.html#Alvao_API_Common_Exceptions_PeriodicAlertException__ctor_System_String_System_Exception_"/>
    public PeriodicAlertException(string message, Exception innerException) { }
}
