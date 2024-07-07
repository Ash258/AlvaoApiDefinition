using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_InvalidBulkMoveException.htm"/>
[SerializableAttribute]
public class InvalidBulkMoveException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidBulkMoveException__ctor.htm"/>
    public InvalidBulkMoveException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidBulkMoveException__ctor_2.htm"/>
    public InvalidBulkMoveException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidBulkMoveException__ctor_1.htm"/>
    public InvalidBulkMoveException(
        SerializationInfo info,
        StreamingContext context
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_InvalidBulkMoveException__ctor_3.htm"/>
    public InvalidBulkMoveException(
        string message,
        Exception innerException
    )
    { }
}
