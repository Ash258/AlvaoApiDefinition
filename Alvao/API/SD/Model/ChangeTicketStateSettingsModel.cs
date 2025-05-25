using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html"/>
public class ChangeTicketStateSettingsModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_ActAuthor"/>
    public tPerson ActAuthor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_ApprovalNoticeModel"/>
    public HtmlTextModel ApprovalNoticeModel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_Cost"/>
    public CostModel Cost { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_CreatedByMachine"/>
    public string CreatedByMachine { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_CreatedByProcessPid"/>
    public int? CreatedByProcessPid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IgnoreApprovalCheck"/>
    public bool IgnoreApprovalCheck { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IgnoreRequiredColumns"/>
    public bool IgnoreRequiredColumns { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IgnoreRights"/>
    public bool IgnoreRights { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterApproval"/>
    public bool IsAfterApproval { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterClose"/>
    public bool IsAfterClose { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterRemove"/>
    public bool IsAfterRemove { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterResolve"/>
    public bool IsAfterResolve { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_IsAfterRestoreRemoved"/>
    public bool IsAfterRestoreRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_LogChange"/>
    public bool LogChange { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_Message"/>
    public HtmlTextModel Message { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_NotifyUserOnReopen"/>
    public bool NotifyUserOnReopen { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_RequesterId"/>
    public int? RequesterId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_RequesterNotice"/>
    public HtmlTextModel RequesterNotice { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_SolverGroupChangeEnabled"/>
    public bool SolverGroupChangeEnabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel_SolverReopen"/>
    public bool SolverReopen { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ChangeTicketStateSettingsModel.html#Alvao_API_SD_Model_ChangeTicketStateSettingsModel__ctor"/>
    public ChangeTicketStateSettingsModel() { }
}
