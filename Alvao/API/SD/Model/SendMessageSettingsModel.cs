using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html"/>
public class SendMessageSettingsModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_ActMark"/>
    public ActMark.ActMarkId? ActMark { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_CallCustomApps"/>
    public bool CallCustomApps { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_Cost"/>
    public CostModel Cost { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_FirstRecipientToId"/>
    public int FirstRecipientToId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_IgnoreRights"/>
    public bool IgnoreRights { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_RecipientsCc"/>
    public string RecipientsCc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_RecipientsTo"/>
    public string RecipientsTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_SelectedNewState"/>
    public int SelectedNewState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_SendNotifyOnMessageSent"/>
    public bool SendNotifyOnMessageSent { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_UserRead"/>
    public bool? UserRead { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel_WaitForReply"/>
    public bool WaitForReply { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SendMessageSettingsModel.html#Alvao_API_SD_Model_SendMessageSettingsModel__ctor"/>
    public SendMessageSettingsModel() { }
}
