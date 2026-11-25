using System.Text.Json.Serialization;

namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SharedShiftBetaModel.html"/>
public class SharedShiftBetaModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SharedShiftBetaModel.html#Alvao_API_SD_Model_SolverAvailability_SharedShiftBetaModel_EndDateTime"/>
    [JsonPropertyName("endDateTime")]
    public DateTimeOffset? EndDateTime { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.SharedShiftBetaModel.html#Alvao_API_SD_Model_SolverAvailability_SharedShiftBetaModel_StartDateTime"/>
    [JsonPropertyName("startDateTime")]
    public DateTimeOffset? StartDateTime { get; set; }
}
