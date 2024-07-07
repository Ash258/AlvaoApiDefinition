namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Exceptions_UserTokenServiceError.htm"/>
public class UserTokenServiceError : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Exceptions_UserTokenServiceError_ErrorCodes.htm"/>
    public IEnumerable<int> ErrorCodes { get; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_UserTokenServiceError__ctor.htm"/>
    public UserTokenServiceError() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_UserTokenServiceError__ctor_1.htm"/>
    public UserTokenServiceError(
        string message,
        IEnumerable<int> errorCodes
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_UserTokenServiceError__ctor_2.htm"/>
    public UserTokenServiceError(
        string message,
        Exception innerException
    )
    { }
}
