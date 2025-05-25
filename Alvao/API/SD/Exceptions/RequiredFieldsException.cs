using System.Runtime.Serialization;
using Alvao.API.SD.Model;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.RequiredFieldsException.html"/>
public class RequiredFieldsException : ValidationException, ISerializable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.RequiredFieldsException.html#Alvao_API_SD_Exceptions_RequiredFieldsException_Fields"/>
    public IEnumerable<StateRequiredColumnModel> Fields { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.RequiredFieldsException.html#Alvao_API_SD_Exceptions_RequiredFieldsException_Message"/>
    public string Message { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.RequiredFieldsException.html#Alvao_API_SD_Exceptions_RequiredFieldsException__ctor"/>
    public RequiredFieldsException() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.RequiredFieldsException.html#Alvao_API_SD_Exceptions_RequiredFieldsException__ctor_System_Collections_Generic_IEnumerable_Alvao_API_SD_Model_StateRequiredColumnModel__System_String_"/>
    public RequiredFieldsException(IEnumerable<StateRequiredColumnModel> fields, string messageText = null) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.RequiredFieldsException.html#Alvao_API_SD_Exceptions_RequiredFieldsException__ctor_System_String_"/>
    public RequiredFieldsException(string message) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.RequiredFieldsException.html#Alvao_API_SD_Exceptions_RequiredFieldsException__ctor_System_String_System_Exception_"/>
    public RequiredFieldsException(string message, Exception innerException) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Exceptions.RequiredFieldsException.html#Alvao_API_SD_Exceptions_RequiredFieldsException_GetMessageWithRequiredFields"/>
    public string GetMessageWithRequiredFields() { throw new System.NotImplementedException(); }
}
