using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsWillLoseResponsibilityException.html"/>
[Serializable]
public class ObjectsWillLoseResponsibilityException : InvalidOperationException, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsWillLoseResponsibilityException.html#Alvao_API_AM_Exceptions_ObjectsWillLoseResponsibilityException__ctor"/>
    public ObjectsWillLoseResponsibilityException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsWillLoseResponsibilityException.html#Alvao_API_AM_Exceptions_ObjectsWillLoseResponsibilityException__ctor_System_String_"/>
    public ObjectsWillLoseResponsibilityException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsWillLoseResponsibilityException.html#Alvao_API_AM_Exceptions_ObjectsWillLoseResponsibilityException__ctor_System_String_System_Exception_"/>
    public ObjectsWillLoseResponsibilityException(string message, Exception innerException) { }
}
