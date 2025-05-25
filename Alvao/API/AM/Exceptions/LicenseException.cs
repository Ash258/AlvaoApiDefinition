using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseException.html"/>
public class LicenseException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseException.html#Alvao_API_AM_Exceptions_LicenseException__ctor"/>
    public LicenseException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseException.html#Alvao_API_AM_Exceptions_LicenseException__ctor_System_String_"/>
    public LicenseException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseException.html#Alvao_API_AM_Exceptions_LicenseException__ctor_System_String_System_Exception_"/>
    public LicenseException(string message, Exception innerException) { }
}
