namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Exceptions_SlaAccessException.htm"/>
public class SlaAccessException : Exception {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_SlaAccessException__ctor.htm"/>
    public SlaAccessException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_SlaAccessException__ctor_1.htm"/>
    public SlaAccessException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_SlaAccessException__ctor_2.htm"/>
    public SlaAccessException(
        string message,
        Exception inner
    ) { }
}
