using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html"/>
public class ActCreateSettings {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActAutoSubmitted"/>
    public string ActAutoSubmitted { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActCc"/>
    public string ActCc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActCreated"/>
    public DateTime? ActCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActCreatedByMachine"/>
    public string ActCreatedByMachine { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActCreatedByProcessId"/>
    public int? ActCreatedByProcessId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActMark"/>
    public ActMark.ActMarkId? ActMark { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActOperation"/>
    public ActOperation.ActOperationId? ActOperation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActSpamLevel"/>
    public string ActSpamLevel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActSpamStatus"/>
    public string ActSpamStatus { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ActTo"/>
    public string ActTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_CallCustomApps"/>
    public bool CallCustomApps { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_Cost"/>
    public CostModel Cost { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_IgnoreRights"/>
    public bool IgnoreRights { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_MessageId"/>
    public string MessageId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_RemoveServiceMail"/>
    public bool RemoveServiceMail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_SaveOnlyPlainText"/>
    public bool SaveOnlyPlainText { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_SendEmail"/>
    public bool SendEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_SendNewMessageNotificationType"/>
    public int SendNewMessageNotificationType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_SendNotifyOnMessageSent"/>
    public bool SendNotifyOnMessageSent { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_SendNotifyOnReplyReceivedToActId"/>
    public int? SendNotifyOnReplyReceivedToActId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_SenderEmail"/>
    public string SenderEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_ShowToRequester"/>
    public bool? ShowToRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_StartingMailAct"/>
    public bool StartingMailAct { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings_WaitingForUser"/>
    public bool? WaitingForUser { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ActCreateSettings.html#Alvao_API_SD_Model_ActCreateSettings__ctor"/>
    public ActCreateSettings() { }
}
