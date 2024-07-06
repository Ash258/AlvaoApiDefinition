namespace Alvao.API.AM.Exceptions;

public class LicenseRelationConditionViolatedException : Exception
{
    public LicenseRelationConditionViolatedException() { }
    public LicenseRelationConditionViolatedException(
        string message
    )
    { }
    public LicenseRelationConditionViolatedException(
        string message,
        Exception innerException
    )
    { }
}
