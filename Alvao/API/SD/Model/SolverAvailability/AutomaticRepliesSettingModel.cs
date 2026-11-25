using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.AutomaticRepliesSettingModel.html"/>
public class AutomaticRepliesSettingModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.AutomaticRepliesSettingModel.html#Alvao_API_SD_Model_SolverAvailability_AutomaticRepliesSettingModel_InternalReplyMessageHtml"/>
    public string InternalReplyMessageHtml { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.AutomaticRepliesSettingModel.html#Alvao_API_SD_Model_SolverAvailability_AutomaticRepliesSettingModel_ScheduledEnd"/>
    public DateTime? ScheduledEnd { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.AutomaticRepliesSettingModel.html#Alvao_API_SD_Model_SolverAvailability_AutomaticRepliesSettingModel_ScheduledStart"/>
    public DateTime? ScheduledStart { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.AutomaticRepliesSettingModel.html#Alvao_API_SD_Model_SolverAvailability_AutomaticRepliesSettingModel_Status"/>
    public AutomaticRepliesStatus.Status Status { get; set; }
}
