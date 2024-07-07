namespace Alvao.API.Common.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Exceptions_MissingSenderException.htm"/>
public class MissingSenderException : Exception
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_MissingSenderException__ctor.htm"/>
    public MissingSenderException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_MissingSenderException__ctor_1.htm"/>
    public MissingSenderException(
        string message
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Exceptions_MissingSenderException__ctor_2.htm"/>
    public MissingSenderException(
        string message,
        Exception innerException
    )
    { }
}
