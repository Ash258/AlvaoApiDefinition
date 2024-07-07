namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_LicenseUnauthorizedAccessException.htm"/>
public class LicenseUnauthorizedAccessException : LicenseException
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_LicenseUnauthorizedAccessException__ctor.htm"/>
    public LicenseUnauthorizedAccessException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_LicenseUnauthorizedAccessException__ctor_1.htm"/>
    public LicenseUnauthorizedAccessException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_LicenseUnauthorizedAccessException__ctor_2.htm"/>
    public LicenseUnauthorizedAccessException(
        string message,
        Exception innerException
    )
    { }
}
