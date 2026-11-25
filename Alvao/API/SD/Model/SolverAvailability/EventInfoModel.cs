using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.EventInfoModel.html"/>
public class EventInfoModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.EventInfoModel.html#Alvao_API_SD_Model_SolverAvailability_EventInfoModel_End"/>
    public DateTime? End { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.EventInfoModel.html#Alvao_API_SD_Model_SolverAvailability_EventInfoModel_IsAllDay"/>
    public bool IsAllDay { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.EventInfoModel.html#Alvao_API_SD_Model_SolverAvailability_EventInfoModel_PersonId"/>
    public int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.EventInfoModel.html#Alvao_API_SD_Model_SolverAvailability_EventInfoModel_ShowAs"/>
    public CalendarEvent.ShowAs ShowAs { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.EventInfoModel.html#Alvao_API_SD_Model_SolverAvailability_EventInfoModel_Start"/>
    public DateTime? Start { get; set; }
}
