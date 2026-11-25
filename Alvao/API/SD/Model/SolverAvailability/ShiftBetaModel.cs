using System.Text.Json.Serialization;

namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.ShiftBetaModel.html"/>
public class ShiftBetaModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.ShiftBetaModel.html#Alvao_API_SD_Model_SolverAvailability_ShiftBetaModel_Id"/>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.ShiftBetaModel.html#Alvao_API_SD_Model_SolverAvailability_ShiftBetaModel_SharedShift"/>
    [JsonPropertyName("sharedShift")]
    public SharedShiftBetaModel SharedShift { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.ShiftBetaModel.html#Alvao_API_SD_Model_SolverAvailability_ShiftBetaModel_lastModifiedDateTime"/>
    public DateTimeOffset? lastModifiedDateTime { get; set; }
}
