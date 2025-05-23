namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_ObjectPropertyAutoActionException.htm"/>
[SerializableAttribute]
public class ObjectPropertyAutoActionException : Exception {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectPropertyAutoActionException__ctor.htm"/>
    public ObjectPropertyAutoActionException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectPropertyAutoActionException__ctor_1.htm"/>
    public ObjectPropertyAutoActionException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectPropertyAutoActionException__ctor_2.htm"/>
    public ObjectPropertyAutoActionException(
        string message,
        Exception innerException
    ) { }
}
