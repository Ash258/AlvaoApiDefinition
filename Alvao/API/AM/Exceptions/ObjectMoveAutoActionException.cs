namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_ObjectMoveAutoActionException.htm"/>
[SerializableAttribute]
public class ObjectMoveAutoActionException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectMoveAutoActionException__ctor.htm"/>
    public ObjectMoveAutoActionException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectMoveAutoActionException__ctor_1.htm"/>
    public ObjectMoveAutoActionException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectMoveAutoActionException__ctor_2.htm"/>
    public ObjectMoveAutoActionException(
        string message,
        Exception innerException
    )
    { }
}
