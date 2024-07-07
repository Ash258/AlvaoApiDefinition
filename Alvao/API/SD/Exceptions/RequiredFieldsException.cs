using Alvao.API.SD.Model;

namespace Alvao.API.SD.Exceptions;

public class RequiredFieldsException : ValidationException
{
    public string Field { get; }
    public IEnumerable<StateRequiredColumnModel> Fields { get; }
    public string Message { get; }

    public RequiredFieldsException() { }
    public RequiredFieldsException(
        string message
    )
    { }
    public RequiredFieldsException(
        IEnumerable<StateRequiredColumnModel> fields,
        string messageText = null
    )
    { }
    public RequiredFieldsException(
        string message,
        Exception innerException
    )
    { }

    public string GetMessageWithRequiredFields() { throw new System.NotImplementedException(); }
}
