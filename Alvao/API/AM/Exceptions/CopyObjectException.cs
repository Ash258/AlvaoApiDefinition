namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_CopyObjectException.htm"/>
[SerializableAttribute]
public class CopyObjectException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_CopyObjectException__ctor.htm"/>
    public CopyObjectException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_CopyObjectException__ctor_1.htm"/>
    public CopyObjectException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_CopyObjectException__ctor_2.htm"/>
    public CopyObjectException(
        string message,
        Exception innerException
    )
    { }
}
