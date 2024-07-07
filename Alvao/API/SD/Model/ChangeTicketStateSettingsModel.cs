using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

public class ChangeTicketStateSettingsModel
{
    public tPerson ActAuthor { get; set; }
    public HtmlTextModel ApprovalNoticeModel { get; set; }
    public CostModel Cost { get; set; }
    public string CreatedByMachine { get; set; }
    public int? CreatedByProcessPid { get; set; }
    public bool IgnoreApprovalCheck { get; set; }
    public bool IgnoreRequiredColumns { get; set; }
    public bool IgnoreRights { get; set; }
    public bool IsAfterApproval { get; set; }
    public bool IsAfterClose { get; set; }
    public bool IsAfterRemove { get; set; }
    public bool IsAfterResolve { get; set; }
    public bool IsAfterRestoreRemoved { get; set; }
    public bool LogChange { get; set; }
    public HtmlTextModel Message { get; set; }
    public bool NotifyUserOnReopen { get; set; }
    public int? RequesterId { get; set; }
    public HtmlTextModel RequesterNotice { get; set; }
    public bool SolverGroupChangeEnabled { get; set; }
    public bool SolverReopen { get; set; }

    public ChangeTicketStateSettingsModel() { }
}
