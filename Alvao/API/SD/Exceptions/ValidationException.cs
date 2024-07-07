namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Exceptions_ValidationException.htm"/>
public class ValidationException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Exceptions_ValidationException_Field.htm"/>
    public string Field { get; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationException__ctor.htm"/>
    public ValidationException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationException__ctor_1.htm"/>
    public ValidationException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationException__ctor_2.htm"/>
    public ValidationException(
        string message,
        Exception innerException
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationException__ctor_3.htm"/>
    public ValidationException(
        string format,
        params Object[] args
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationException__ctor_4.htm"/>
    public ValidationException(
        string field,
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationException__ctor_5.htm"/>
    public ValidationException(
        string field,
        string format,
        params Object[] args
    )
    { }
}
