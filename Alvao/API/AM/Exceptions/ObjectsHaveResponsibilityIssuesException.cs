using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsHaveResponsibilityIssuesException.html"/>
[Serializable]
public class ObjectsHaveResponsibilityIssuesException : InvalidOperationException, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsHaveResponsibilityIssuesException.html#Alvao_API_AM_Exceptions_ObjectsHaveResponsibilityIssuesException_AffectedObjectIds"/>
    public IEnumerable<int> AffectedObjectIds { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsHaveResponsibilityIssuesException.html#Alvao_API_AM_Exceptions_ObjectsHaveResponsibilityIssuesException__ctor"/>
    public ObjectsHaveResponsibilityIssuesException() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsHaveResponsibilityIssuesException.html#Alvao_API_AM_Exceptions_ObjectsHaveResponsibilityIssuesException__ctor_System_String_"/>
    public ObjectsHaveResponsibilityIssuesException(string message) { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Exceptions.ObjectsHaveResponsibilityIssuesException.html#Alvao_API_AM_Exceptions_ObjectsHaveResponsibilityIssuesException__ctor_System_String_System_Exception_"/>
    public ObjectsHaveResponsibilityIssuesException(string message, Exception innerException) { }
}
