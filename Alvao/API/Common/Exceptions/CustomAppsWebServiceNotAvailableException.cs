using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.CustomAppsWebServiceNotAvailableException.html"/>
public class CustomAppsWebServiceNotAvailableException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.CustomAppsWebServiceNotAvailableException.html#Alvao_API_Common_Exceptions_CustomAppsWebServiceNotAvailableException__ctor"/>
    public CustomAppsWebServiceNotAvailableException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.CustomAppsWebServiceNotAvailableException.html#Alvao_API_Common_Exceptions_CustomAppsWebServiceNotAvailableException__ctor_System_String_"/>
    public CustomAppsWebServiceNotAvailableException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.CustomAppsWebServiceNotAvailableException.html#Alvao_API_Common_Exceptions_CustomAppsWebServiceNotAvailableException__ctor_System_String_System_Exception_"/>
    public CustomAppsWebServiceNotAvailableException(string message, Exception innerException) { }
}
