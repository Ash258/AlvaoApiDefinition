namespace Alvao.API.AM.Exceptions;

public class LicenseInvalidPropertyValueException : LicenseException
{
    public enum LicenseProperty
    {
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


    public LicenseInvalidPropertyValueException() { }
    public LicenseInvalidPropertyValueException(
        LicenseInvalidPropertyValueException.LicenseProperty property
    )
    { }
    public LicenseInvalidPropertyValueException(
        string message,
        LicenseInvalidPropertyValueException.LicenseProperty property
    )
    { }
    public LicenseInvalidPropertyValueException(
        string message,
        Exception innerException,
        LicenseInvalidPropertyValueException.LicenseProperty property
    )
    { }
}
