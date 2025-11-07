using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationMissingMandatoryFieldsException.html"/>
[Serializable]
public class ObjectRelationMissingMandatoryFieldsException : ObjectRelationConditionViolatedException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationMissingMandatoryFieldsException.html#Alvao_API_AM_Exceptions_ObjectRelationMissingMandatoryFieldsException__ctor_System_String_"/>
    public ObjectRelationMissingMandatoryFieldsException(string message) { }
}
