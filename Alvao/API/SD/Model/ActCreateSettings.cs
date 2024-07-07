using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_ActCreateSettings.htm"/>
public class ActCreateSettings
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActAutoSubmitted.htm"/>
    public string ActAutoSubmitted { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActCc.htm"/>
    public string ActCc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActCreated.htm"/>
    public DateTime? ActCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActCreatedByMachine.htm"/>
    public string ActCreatedByMachine { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActCreatedByProcessId.htm"/>
    public int? ActCreatedByProcessId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActMark.htm"/>
    public ActMark.ActMarkId? ActMark { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActOperation.htm"/>
    public ActOperation.ActOperationId? ActOperation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActSpamLevel.htm"/>
    public string ActSpamLevel { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActSpamStatus.htm"/>
    public string ActSpamStatus { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ActTo.htm"/>
    public string ActTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_CallCustomApps.htm"/>
    public bool CallCustomApps { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_Cost.htm"/>
    public CostModel Cost { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_IgnoreRights.htm"/>
    public bool IgnoreRights { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_MessageId.htm"/>
    public string MessageId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_RemoveServiceMail.htm"/>
    public bool RemoveServiceMail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_SaveOnlyPlainText.htm"/>
    public bool SaveOnlyPlainText { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_SendEmail.htm"/>
    public bool SendEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_SenderEmail.htm"/>
    public string SenderEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_SendNewMessageNotificationType.htm"/>
    public int SendNewMessageNotificationType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_SendNotifyOnMessageSent.htm"/>
    public bool SendNotifyOnMessageSent { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_SendNotifyOnReplyReceivedToActId.htm"/>
    public int? SendNotifyOnReplyReceivedToActId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_ShowToRequester.htm"/>
    public bool? ShowToRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_StartingMailAct.htm"/>
    public bool StartingMailAct { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ActCreateSettings_WaitingForUser.htm"/>
    public bool? WaitingForUser { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_ActCreateSettings__ctor.htm"/>
    public ActCreateSettings() { }
}
