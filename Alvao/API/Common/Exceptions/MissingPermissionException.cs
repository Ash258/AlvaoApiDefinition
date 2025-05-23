namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Exceptions_MissingPermissionException.htm"/>
public class MissingPermissionException : Exception {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_MissingPermissionException__ctor.htm"/>
    public MissingPermissionException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_MissingPermissionException__ctor_1.htm"/>
    public MissingPermissionException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_MissingPermissionException__ctor_2.htm"/>
    public MissingPermissionException(
        string message,
        Exception innerException
    ) { }
}
