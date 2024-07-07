namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_ObjectNotFoundException.htm"/>
public class ObjectNotFoundException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectNotFoundException__ctor.htm"/>
    public ObjectNotFoundException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectNotFoundException__ctor_1.htm"/>
    public ObjectNotFoundException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectNotFoundException__ctor_2.htm"/>
    public ObjectNotFoundException(
        string message,
        Exception innerException
    )
    { }
}
