namespace Alvao.API.AM.Exceptions;

[SerializableAttribute]
public class ObjectRelationConditionViolatedException : Exception
{
    public ObjectRelationConditionViolatedException() { }
    public ObjectRelationConditionViolatedException(
        string message
    )
    { }
    public ObjectRelationConditionViolatedException(
        string message,
        Exception innerException
    )
    { }
}
