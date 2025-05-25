using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseRelationConditionViolatedException.html"/>
public class LicenseRelationConditionViolatedException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseRelationConditionViolatedException.html#Alvao_API_AM_Exceptions_LicenseRelationConditionViolatedException__ctor"/>
    public LicenseRelationConditionViolatedException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseRelationConditionViolatedException.html#Alvao_API_AM_Exceptions_LicenseRelationConditionViolatedException__ctor_System_String_"/>
    public LicenseRelationConditionViolatedException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseRelationConditionViolatedException.html#Alvao_API_AM_Exceptions_LicenseRelationConditionViolatedException__ctor_System_String_System_Exception_"/>
    public LicenseRelationConditionViolatedException(string message, Exception innerException) { }
}
