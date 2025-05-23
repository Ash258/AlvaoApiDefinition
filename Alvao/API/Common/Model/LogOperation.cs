namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_LogOperation.htm"/>
public static class LogOperation {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_LogOperation_Operation.htm"/>
    public enum Operation {
        Insert = 1,
        Edit = 2,
        Remove = 3,
    }
}
