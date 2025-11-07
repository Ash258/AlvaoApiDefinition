using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationAlreadyExistsException.html"/>
[Serializable]
public class ObjectRelationAlreadyExistsException : ObjectRelationConditionViolatedException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationAlreadyExistsException.html#Alvao_API_AM_Exceptions_ObjectRelationAlreadyExistsException_DuplicateRelationId"/>
    public int DuplicateRelationId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.ObjectRelationAlreadyExistsException.html#Alvao_API_AM_Exceptions_ObjectRelationAlreadyExistsException__ctor_System_String_System_Int32_"/>
    public ObjectRelationAlreadyExistsException(string message, int duplicateRelationId) { }
}
