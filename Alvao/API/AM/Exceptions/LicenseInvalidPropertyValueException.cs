using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseInvalidPropertyValueException.html"/>
public class LicenseInvalidPropertyValueException : LicenseException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseInvalidPropertyValueException.LicenseProperty.html#fields"/>
    public enum LicenseProperty {
        LicenseCount = 0,
        LicenseCountAssigned = 1,
        ExpireBeforeValid = 2,
        LicenseName = 3,
        LicenseTypeAndQuantityUnitCombination = 4,
        PerUserAssigned = 5,
        PerProcessorAssigned = 6,
        QuantityUnitAndObjectTypeCombination = 7,
        AvailableLicensesExceeded = 8,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseInvalidPropertyValueException.html#Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException_Property"/>
    public LicenseInvalidPropertyValueException.LicenseProperty Property { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseInvalidPropertyValueException.html#Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException__ctor"/>
    public LicenseInvalidPropertyValueException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseInvalidPropertyValueException.html#Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException__ctor_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException_LicenseProperty_"/>
    public LicenseInvalidPropertyValueException(LicenseInvalidPropertyValueException.LicenseProperty property) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseInvalidPropertyValueException.html#Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException__ctor_System_String_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException_LicenseProperty_"/>
    public LicenseInvalidPropertyValueException(string message, LicenseInvalidPropertyValueException.LicenseProperty property) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.LicenseInvalidPropertyValueException.html#Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException__ctor_System_String_System_Exception_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException_LicenseProperty_"/>
    public LicenseInvalidPropertyValueException(string message, Exception innerException, LicenseInvalidPropertyValueException.LicenseProperty property) { }
}
