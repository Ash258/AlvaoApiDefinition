namespace Alvao.API.AM.Exceptions;

public class LicenseAlreadyAssignedException : LicenseException
{
    public LicenseAlreadyAssignedException() { }
    public LicenseAlreadyAssignedException(
        string message
    )
    { }
    public LicenseAlreadyAssignedException(
        string message,
        Exception innerException
    )
    { }
}
