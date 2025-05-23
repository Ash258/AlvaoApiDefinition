namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Exceptions_SqlInjectionException.htm"/>
public class SqlInjectionException : Exception {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_SqlInjectionException__ctor.htm"/>
    public SqlInjectionException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_SqlInjectionException__ctor_1.htm"/>
    public SqlInjectionException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_SqlInjectionException__ctor_2.htm"/>
    public SqlInjectionException(
        string message,
        Exception inner
    ) { }
}
