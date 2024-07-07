namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_UnauthorizedObjectOperationEception.htm"/>
[SerializableAttribute]
public class UnauthorizedObjectOperationEception : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_UnauthorizedObjectOperationEception__ctor.htm"/>
    public UnauthorizedObjectOperationEception() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_UnauthorizedObjectOperationEception__ctor_1.htm"/>
    public UnauthorizedObjectOperationEception(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_UnauthorizedObjectOperationEception__ctor_2.htm"/>
    public UnauthorizedObjectOperationEception(
        string message,
        Exception innerException
    )
    { }
}
