using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <summary>
/// Ticket initial act settings
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_InitialActSettings.htm"/>
public class InitialActSettings : ActCreateSettings
{
    /// <summary>Initial act author. If null, ticket requester is set.</summary>
    public tPerson ActAuthor { get; set; }
    public string ActAutoSubmitted { get; set; }
    public string ActCc { get; set; }
    public DateTime? ActCreated { get; set; }
    public string ActCreatedByMachine { get; set; }
    public int? ActCreatedByProcessId { get; set; }
    /// <summary>Act kind,tActKind.ActKind.Form is default.</summary>
    public tActKind.ActKind ActKind { get; set; }
    public ActMark.ActMarkId? ActMark { get; set; }
    public ActOperation.ActOperationId? ActOperation { get; set; }
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
    /// <summary>Initial act receiver, can be null.</summary>
    public tPerson ToPerson { get; set; }
    public bool? WaitingForUser { get; set; }

    public InitialActSettings() { }
}
