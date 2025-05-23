namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Exceptions_ObjectRelationConditionViolatedException.htm"/>
[SerializableAttribute]
public class ObjectRelationConditionViolatedException : Exception {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectRelationConditionViolatedException__ctor.htm"/>
    public ObjectRelationConditionViolatedException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectRelationConditionViolatedException__ctor_1.htm"/>
    public ObjectRelationConditionViolatedException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Exceptions_ObjectRelationConditionViolatedException__ctor_2.htm"/>
    public ObjectRelationConditionViolatedException(
        string message,
        Exception innerException
    ) { }
}
