namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.ConnectionStatusResult.html"/>
public class ConnectionStatusResult {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.ConnectionStatusResult.html#Alvao_API_Common_Model_ConnectionStatusResult_Content"/>
    public string Content { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.ConnectionStatusResult.html#Alvao_API_Common_Model_ConnectionStatusResult_Message"/>
    public string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.ConnectionStatusResult.html#Alvao_API_Common_Model_ConnectionStatusResult_Ok"/>
    public bool? Ok { get; set; }
}
