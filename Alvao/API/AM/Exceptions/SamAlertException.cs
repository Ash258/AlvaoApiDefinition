namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_SamAlertException.htm"/>
public class SamAlertException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_SamAlertException__ctor.htm"/>
    public SamAlertException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_SamAlertException__ctor_1.htm"/>
    public SamAlertException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_SamAlertException__ctor_2.htm"/>
    public SamAlertException(
        string message,
        Exception innerException
    )
    { }
}
