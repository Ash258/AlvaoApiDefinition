namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.DateTimeRangeModel.html"/>
public class DateTimeRangeModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.DateTimeRangeModel.html#Alvao_API_SD_Model_SolverAvailability_DateTimeRangeModel_End"/>
    public DateTime? End { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.DateTimeRangeModel.html#Alvao_API_SD_Model_SolverAvailability_DateTimeRangeModel_IsEmpty"/>
    public bool IsEmpty { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.DateTimeRangeModel.html#Alvao_API_SD_Model_SolverAvailability_DateTimeRangeModel_Length"/>
    public TimeSpan? Length { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.DateTimeRangeModel.html#Alvao_API_SD_Model_SolverAvailability_DateTimeRangeModel_Start"/>
    public DateTime? Start { get; set; }
}
