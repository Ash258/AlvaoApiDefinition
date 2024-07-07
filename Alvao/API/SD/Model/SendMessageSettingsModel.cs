using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_SendMessageSettingsModel.htm"/>
public class SendMessageSettingsModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_ActMark.htm"/>
    public ActMark.ActMarkId? ActMark { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_CallCustomApps.htm"/>
    public bool CallCustomApps { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_Cost.htm"/>
    public CostModel Cost { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_FirstRecipientToId.htm"/>
    public int FirstRecipientToId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_IgnoreRights.htm"/>
    public bool IgnoreRights { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_RecipientsCc.htm"/>
    public string RecipientsCc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_RecipientsTo.htm"/>
    public string RecipientsTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_SelectedNewState.htm"/>
    public int SelectedNewState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_SendNotifyOnMessageSent.htm"/>
    public bool SendNotifyOnMessageSent { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_UserRead.htm"/>
    public bool? UserRead { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SendMessageSettingsModel_WaitForReply.htm"/>
    public bool WaitForReply { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_SendMessageSettingsModel__ctor.htm"/>
    public SendMessageSettingsModel() { }
}
