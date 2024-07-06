namespace Alvao.API.AM.Exceptions;

public class PropertyValueViolatesUniquenessException : InvalidPropertyException
{
    public PropertyValueViolatesUniquenessException() { }
    public PropertyValueViolatesUniquenessException(
        string message
    )
    { }
    public PropertyValueViolatesUniquenessException(
        string message,
        Exception innerException
    )
    { }
}
