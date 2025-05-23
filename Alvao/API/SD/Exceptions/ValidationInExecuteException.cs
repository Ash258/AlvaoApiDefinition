namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Exceptions_ValidationInExecuteException.htm"/>
public class ValidationInExecuteException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Exceptions_ValidationInExecuteException_Field.htm"/>
    public string Field { get; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor.htm"/>
    public ValidationInExecuteException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_1.htm"/>
    public ValidationInExecuteException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_2.htm"/>
    public ValidationInExecuteException(
        string message,
        Exception innerException
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_3.htm"/>
    public ValidationInExecuteException(
        string format,
        params Object[] args
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_4.htm"/>
    public ValidationInExecuteException(
        string field,
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_ValidationInExecuteException__ctor_5.htm"/>
    public ValidationInExecuteException(
        string field,
        string format,
        params Object[] args
    )
    { }
}
