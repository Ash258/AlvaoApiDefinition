using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

public class SendMessageSettingsModel
{
    public ActMark.ActMarkId? ActMark { get; set; }
    public bool CallCustomApps { get; set; }
    public CostModel Cost { get; set; }
    public int FirstRecipientToId { get; set; }
    public bool IgnoreRights { get; set; }
    public string RecipientsCc { get; set; }
    public string RecipientsTo { get; set; }
    public int SelectedNewState { get; set; }
    public bool SendNotifyOnMessageSent { get; set; }
    public bool? UserRead { get; set; }
    public bool WaitForReply { get; set; }

    public SendMessageSettingsModel() { }
}
