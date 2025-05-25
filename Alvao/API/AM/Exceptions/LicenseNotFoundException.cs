using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseNotFoundException.html"/>
public class LicenseNotFoundException : LicenseException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseNotFoundException.html#Alvao_API_AM_Exceptions_LicenseNotFoundException__ctor"/>
    public LicenseNotFoundException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseNotFoundException.html#Alvao_API_AM_Exceptions_LicenseNotFoundException__ctor_System_String_"/>
    public LicenseNotFoundException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseNotFoundException.html#Alvao_API_AM_Exceptions_LicenseNotFoundException__ctor_System_String_System_Exception_"/>
    public LicenseNotFoundException(string message, Exception innerException) { }
}
