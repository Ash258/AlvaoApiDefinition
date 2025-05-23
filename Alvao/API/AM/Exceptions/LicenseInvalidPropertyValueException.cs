namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException.htm"/>
public class LicenseInvalidPropertyValueException : LicenseException {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException_LicenseProperty.htm"/>
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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException_Property.htm"/>
    public LicenseInvalidPropertyValueException.LicenseProperty Property { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException__ctor.htm"/>
    public LicenseInvalidPropertyValueException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException__ctor_1.htm"/>
    public LicenseInvalidPropertyValueException(
        LicenseInvalidPropertyValueException.LicenseProperty property
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException__ctor_2.htm"/>
    public LicenseInvalidPropertyValueException(
        string message,
        LicenseInvalidPropertyValueException.LicenseProperty property
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_LicenseInvalidPropertyValueException__ctor_3.htm"/>
    public LicenseInvalidPropertyValueException(
        string message,
        Exception innerException,
        LicenseInvalidPropertyValueException.LicenseProperty property
    ) { }
}
