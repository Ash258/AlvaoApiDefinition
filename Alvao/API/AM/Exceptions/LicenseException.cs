namespace Alvao.API.AM.Exceptions;

public class LicenseException : Exception
{
    public LicenseException() { }
    public LicenseException(
        string message
    )
    { }
    public LicenseException(
        string message,
        Exception innerException
    )
    { }
}
