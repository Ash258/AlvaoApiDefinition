using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationConditionViolatedException.html"/>
[Serializable]
public class ObjectRelationConditionViolatedException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationConditionViolatedException.html#Alvao_API_AM_Exceptions_ObjectRelationConditionViolatedException__ctor"/>
    public ObjectRelationConditionViolatedException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationConditionViolatedException.html#Alvao_API_AM_Exceptions_ObjectRelationConditionViolatedException__ctor_System_String_"/>
    public ObjectRelationConditionViolatedException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationConditionViolatedException.html#Alvao_API_AM_Exceptions_ObjectRelationConditionViolatedException__ctor_System_String_System_Exception_"/>
    public ObjectRelationConditionViolatedException(string message, Exception innerException) { }
}
