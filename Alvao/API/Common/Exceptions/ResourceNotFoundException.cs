using System.Runtime.Serialization;

namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ResourceNotFoundException.html"/>
public class ResourceNotFoundException : Exception, ISerializable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Exceptions.ResourceNotFoundException.html#Alvao_API_Common_Exceptions_ResourceNotFoundException__ctor"/>
    public ResourceNotFoundException() { }
}
