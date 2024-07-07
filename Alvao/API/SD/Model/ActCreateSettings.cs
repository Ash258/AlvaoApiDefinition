namespace Alvao.API.SD.Model;

public class ActCreateSettings
{
    public string ActAutoSubmitted { get; set; }
    public string ActCc { get; set; }
    public DateTime? ActCreated { get; set; }
    public string ActCreatedByMachine { get; set; }
    public int? ActCreatedByProcessId { get; set; }
    public ActMarkActMarkId? ActMark { get; set; }
    public ActOperationActOperationId? ActOperation { get; set; }
    public string ActSpamLevel { get; set; }
    public string ActSpamStatus { get; set; }
    public string ActTo { get; set; }
    public bool CallCustomApps { get; set; }
    public CostModel Cost { get; set; }
    public bool IgnoreRights { get; set; }
    public string MessageId { get; set; }
    public bool RemoveServiceMail { get; set; }
    public bool SaveOnlyPlainText { get; set; }
    public bool SendEmail { get; set; }
    public string SenderEmail { get; set; }
    public int SendNewMessageNotificationType { get; set; }
    public bool SendNotifyOnMessageSent { get; set; }
    public int? SendNotifyOnReplyReceivedToActId { get; set; }
    public bool? ShowToRequester { get; set; }
    public bool StartingMailAct { get; set; }
    public bool? WaitingForUser { get; set; }

    public ActCreateSettings() { }
}
