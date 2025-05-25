namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.MessageForApproverDataModel.html"/>
public class MessageForApproverDataModel : MessageDataBaseModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.MessageForApproverDataModel.html#Alvao_API_SD_Model_MessageForApproverDataModel_CurrentApprovers"/>
    public string CurrentApprovers { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.MessageForApproverDataModel.html#Alvao_API_SD_Model_MessageForApproverDataModel_ExpirationTime"/>
    public DateTime? ExpirationTime { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.MessageForApproverDataModel.html#Alvao_API_SD_Model_MessageForApproverDataModel_MessageForRequesterActId"/>
    public string MessageForRequesterActId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.MessageForApproverDataModel.html#Alvao_API_SD_Model_MessageForApproverDataModel_MessageForRequesterHtml"/>
    public string MessageForRequesterHtml { get; set; }
}
