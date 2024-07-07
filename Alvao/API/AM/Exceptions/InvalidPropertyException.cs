namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_InvalidPropertyException.htm"/>
public class InvalidPropertyException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidPropertyException__ctor.htm"/>
    public InvalidPropertyException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidPropertyException__ctor_1.htm"/>
    public InvalidPropertyException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidPropertyException__ctor_2.htm"/>
    public InvalidPropertyException(
        string message,
        Exception innerException
    )
    { }
}
