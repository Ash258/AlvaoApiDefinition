namespace Alvao.API.AM.Exceptions;

public class LicenseNotFoundException : LicenseException
{
    public LicenseNotFoundException() { }
    public LicenseNotFoundException(
        string message
    )
    { }
    public LicenseNotFoundException(
        string message,
        Exception innerException
    )
    { }
}
