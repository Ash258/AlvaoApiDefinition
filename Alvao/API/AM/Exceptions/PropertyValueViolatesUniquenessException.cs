using System.Runtime.Serialization;

namespace Alvao.API.AM.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.PropertyValueViolatesUniquenessException.html"/>
public class PropertyValueViolatesUniquenessException : InvalidPropertyException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.PropertyValueViolatesUniquenessException.html#Alvao_API_AM_Exceptions_PropertyValueViolatesUniquenessException__ctor"/>
    public PropertyValueViolatesUniquenessException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.PropertyValueViolatesUniquenessException.html#Alvao_API_AM_Exceptions_PropertyValueViolatesUniquenessException__ctor_System_String_"/>
    public PropertyValueViolatesUniquenessException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Exceptions.PropertyValueViolatesUniquenessException.html#Alvao_API_AM_Exceptions_PropertyValueViolatesUniquenessException__ctor_System_String_System_Exception_"/>
    public PropertyValueViolatesUniquenessException(string message, Exception innerException) { }
}
