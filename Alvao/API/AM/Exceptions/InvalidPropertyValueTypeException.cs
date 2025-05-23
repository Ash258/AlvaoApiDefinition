namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_InvalidPropertyValueTypeException.htm"/>
public class InvalidPropertyValueTypeException : InvalidPropertyException {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidPropertyValueTypeException__ctor.htm"/>
    public InvalidPropertyValueTypeException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidPropertyValueTypeException__ctor_1.htm"/>
    public InvalidPropertyValueTypeException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidPropertyValueTypeException__ctor_2.htm"/>
    public InvalidPropertyValueTypeException(
        string message,
        Exception innerException
    ) { }
}
