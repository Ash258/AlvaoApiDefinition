namespace Alvao.API.AM.Exceptions;

public class LicenseInvalidPropertyValueException : LicenseException
{
    public LicenseInvalidPropertyValueExceptionLicenseProperty Property { get; set; }
}
