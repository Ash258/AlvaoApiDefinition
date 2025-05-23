namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_MessageTemplate.htm"/>
public static class MessageTemplate {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_MessageTemplate_Type.htm"/>
    public enum Type {
        MessageForApprover = 1,
        MessageForRequester = 2,
    }
}
