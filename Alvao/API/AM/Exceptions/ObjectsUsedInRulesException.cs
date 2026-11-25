using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsUsedInRulesException.html"/>
[Serializable]
public class ObjectsUsedInRulesException : InvalidOperationException, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsUsedInRulesException.html#Alvao_API_AM_Exceptions_ObjectsUsedInRulesException__ctor"/>
    public ObjectsUsedInRulesException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsUsedInRulesException.html#Alvao_API_AM_Exceptions_ObjectsUsedInRulesException__ctor_System_String_"/>
    public ObjectsUsedInRulesException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsUsedInRulesException.html#Alvao_API_AM_Exceptions_ObjectsUsedInRulesException__ctor_System_String_System_Exception_"/>
    public ObjectsUsedInRulesException(string message, Exception innerException) { }
}
