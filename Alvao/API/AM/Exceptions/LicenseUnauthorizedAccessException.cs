namespace Alvao.API.AM.Exceptions;

public class LicenseUnauthorizedAccessException : LicenseException
{
    public LicenseUnauthorizedAccessException() { }
    public LicenseUnauthorizedAccessException(
        string message
    )
    { }
    public LicenseUnauthorizedAccessException(
        string message,
        Exception innerException
    )
    { }
}
