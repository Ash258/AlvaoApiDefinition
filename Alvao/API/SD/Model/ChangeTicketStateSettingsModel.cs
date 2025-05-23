using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_ChangeTicketStateSettingsModel.htm"/>
public class ChangeTicketStateSettingsModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_ActAuthor.htm"/>
    public tPerson ActAuthor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_ApprovalNoticeModel.htm"/>
    public HtmlTextModel ApprovalNoticeModel { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_Cost.htm"/>
    public CostModel Cost { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_CreatedByMachine.htm"/>
    public string CreatedByMachine { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_CreatedByProcessPid.htm"/>
    public int? CreatedByProcessPid { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IgnoreApprovalCheck.htm"/>
    public bool IgnoreApprovalCheck { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IgnoreRequiredColumns.htm"/>
    public bool IgnoreRequiredColumns { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IgnoreRights.htm"/>
    public bool IgnoreRights { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterApproval.htm"/>
    public bool IsAfterApproval { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterClose.htm"/>
    public bool IsAfterClose { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterRemove.htm"/>
    public bool IsAfterRemove { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterResolve.htm"/>
    public bool IsAfterResolve { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterRestoreRemoved.htm"/>
    public bool IsAfterRestoreRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_LogChange.htm"/>
    public bool LogChange { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_Message.htm"/>
    public HtmlTextModel Message { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_NotifyUserOnReopen.htm"/>
    public bool NotifyUserOnReopen { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_RequesterId.htm"/>
    public int? RequesterId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_RequesterNotice.htm"/>
    public HtmlTextModel RequesterNotice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_SolverGroupChangeEnabled.htm"/>
    public bool SolverGroupChangeEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_SolverReopen.htm"/>
    public bool SolverReopen { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_ChangeTicketStateSettingsModel__ctor.htm"/>
    public ChangeTicketStateSettingsModel() { }
}
