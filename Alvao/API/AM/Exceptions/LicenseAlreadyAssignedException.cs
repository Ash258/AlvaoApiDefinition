using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseAlreadyAssignedException.html"/>
public class LicenseAlreadyAssignedException : LicenseException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseAlreadyAssignedException.html#Alvao_API_AM_Exceptions_LicenseAlreadyAssignedException__ctor"/>
    public LicenseAlreadyAssignedException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseAlreadyAssignedException.html#Alvao_API_AM_Exceptions_LicenseAlreadyAssignedException__ctor_System_String_"/>
    public LicenseAlreadyAssignedException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseAlreadyAssignedException.html#Alvao_API_AM_Exceptions_LicenseAlreadyAssignedException__ctor_System_String_System_Exception_"/>
    public LicenseAlreadyAssignedException(string message, Exception innerException) { }
}
