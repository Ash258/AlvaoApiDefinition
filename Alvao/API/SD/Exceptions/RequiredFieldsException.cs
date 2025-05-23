using Alvao.API.SD.Model;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Exceptions_RequiredFieldsException.htm"/>
public class RequiredFieldsException : ValidationException
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Exceptions_ValidationException_Field.htm"/>
    public string Field { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Exceptions_RequiredFieldsException_Fields.htm"/>
    public IEnumerable<StateRequiredColumnModel> Fields { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Exceptions_RequiredFieldsException_Message.htm"/>
    public string Message { get; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_RequiredFieldsException__ctor.htm"/>
    public RequiredFieldsException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_RequiredFieldsException__ctor_2.htm"/>
    public RequiredFieldsException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_RequiredFieldsException__ctor_1.htm"/>
    public RequiredFieldsException(
        IEnumerable<StateRequiredColumnModel> fields,
        string messageText = null
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_RequiredFieldsException__ctor_3.htm"/>
    public RequiredFieldsException(
        string message,
        Exception innerException
    )
    { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_RequiredFieldsException_GetMessageWithRequiredFields.htm"/>
    public string GetMessageWithRequiredFields() { throw new System.NotImplementedException(); }
}
