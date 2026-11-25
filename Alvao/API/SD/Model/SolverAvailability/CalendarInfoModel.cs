namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarInfoModel.html"/>
public class CalendarInfoModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarInfoModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarInfoModel_Events"/>
    public IEnumerable<EventInfoModel> Events { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarInfoModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarInfoModel_OutOfOffice"/>
    public IEnumerable<OutOfOfficeInfoModel> OutOfOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarInfoModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarInfoModel_Shifts"/>
    public IEnumerable<ShiftInfoModel> Shifts { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.CalendarInfoModel.html#Alvao_API_SD_Model_SolverAvailability_CalendarInfoModel_TicketDeadline"/>
    public DateTime? TicketDeadline { get; set; }
}
