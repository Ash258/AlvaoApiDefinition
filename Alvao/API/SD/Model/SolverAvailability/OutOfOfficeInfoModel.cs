using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html"/>
public class OutOfOfficeInfoModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_AutoReplies"/>
    public bool AutoReplies { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_AutoRepliesEnd"/>
    public DateTime? AutoRepliesEnd { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_AutoRepliesMessage"/>
    public string AutoRepliesMessage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_AutoRepliesStart"/>
    public DateTime? AutoRepliesStart { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_OutOfOffice"/>
    public bool OutOfOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_OutOfOfficeEnd"/>
    public DateTime? OutOfOfficeEnd { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_OutOfOfficeStart"/>
    public DateTime? OutOfOfficeStart { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_PersonId"/>
    public int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_Status"/>
    public AutomaticRepliesStatus.Status Status { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.OutOfOfficeInfoModel.html#Alvao_API_SD_Model_SolverAvailability_OutOfOfficeInfoModel_SyncAvailability"/>
    public bool SyncAvailability { get; set; }
}
