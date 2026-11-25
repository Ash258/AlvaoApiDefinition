using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarEventModel.html"/>
public class CalendarEventModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarEventModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarEventModel_End"/>
    public DateTime? End { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarEventModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarEventModel_GraphEventId"/>
    public string GraphEventId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarEventModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarEventModel_GraphSeriesMasterId"/>
    public string GraphSeriesMasterId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarEventModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarEventModel_IsAllDay"/>
    public bool IsAllDay { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarEventModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarEventModel_ShowAsId"/>
    public CalendarEvent.ShowAs ShowAsId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarEventModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarEventModel_Start"/>
    public DateTime? Start { get; set; }
}
