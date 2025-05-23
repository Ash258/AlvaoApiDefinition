using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_InvalidMoveException.htm"/>
[SerializableAttribute]
public class InvalidMoveException : Exception {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidMoveException__ctor.htm"/>
    public InvalidMoveException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidMoveException__ctor_2.htm"/>
    public InvalidMoveException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidMoveException__ctor_1.htm"/>
    public InvalidMoveException(
        SerializationInfo info,
        StreamingContext context
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidMoveException__ctor_3.htm"/>
    public InvalidMoveException(
        string message,
        Exception innerException
    ) { }
}
