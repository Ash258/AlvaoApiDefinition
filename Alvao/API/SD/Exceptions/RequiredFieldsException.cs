namespace Alvao.API.SD.Exceptions;

public class RequiredFieldsException : ValidationException
{
    public RequiredFieldsException(
        string message,
        Exception innerException
    )
    { }

    public string GetMessageWithRequiredFields() { throw new System.NotImplementedException(); }
}
