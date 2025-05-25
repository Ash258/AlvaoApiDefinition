using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseUnauthorizedAccessException.html"/>
public class LicenseUnauthorizedAccessException : LicenseException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseUnauthorizedAccessException.html#Alvao_API_AM_Exceptions_LicenseUnauthorizedAccessException__ctor"/>
    public LicenseUnauthorizedAccessException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseUnauthorizedAccessException.html#Alvao_API_AM_Exceptions_LicenseUnauthorizedAccessException__ctor_System_String_"/>
    public LicenseUnauthorizedAccessException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseUnauthorizedAccessException.html#Alvao_API_AM_Exceptions_LicenseUnauthorizedAccessException__ctor_System_String_System_Exception_"/>
    public LicenseUnauthorizedAccessException(string message, Exception innerException) { }
}
