using System.Runtime.Serialization;

namespace Alvao.API.SD.Exceptions;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Exceptions_BackResolveException.htm"/>
public class BackResolveException : Exception {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_BackResolveException__ctor.htm"/>
    public BackResolveException() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_BackResolveException__ctor_2.htm"/>
    public BackResolveException(
        string message
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_BackResolveException__ctor_1.htm"/>
    public BackResolveException(
        SerializationInfo info,
        StreamingContext context
    ) { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Exceptions_BackResolveException__ctor_3.htm"/>
    public BackResolveException(
        string message,
        Exception inner
    ) { }
}
