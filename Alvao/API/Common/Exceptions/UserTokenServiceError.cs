using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.UserTokenServiceError.html"/>
public class UserTokenServiceError : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.UserTokenServiceError.html#Alvao_API_Common_Exceptions_UserTokenServiceError_ErrorCodes"/>
    public IEnumerable<int> ErrorCodes { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.UserTokenServiceError.html#Alvao_API_Common_Exceptions_UserTokenServiceError__ctor"/>
    public UserTokenServiceError() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.UserTokenServiceError.html#Alvao_API_Common_Exceptions_UserTokenServiceError__ctor_System_String_System_Collections_Generic_IEnumerable_System_Int32__"/>
    public UserTokenServiceError(string message, IEnumerable<int> errorCodes) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Exceptions.UserTokenServiceError.html#Alvao_API_Common_Exceptions_UserTokenServiceError__ctor_System_String_System_Exception_"/>
    public UserTokenServiceError(string message, Exception innerException) { }
}
