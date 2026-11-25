using System.Text.Json.Serialization;

namespace Alvao.API.SD.Model.SolverAvailability;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.ShiftCollectionBetaResponseModel.html"/>
public class ShiftCollectionBetaResponseModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.SolverAvailability.ShiftCollectionBetaResponseModel.html#Alvao_API_SD_Model_SolverAvailability_ShiftCollectionBetaResponseModel_Value"/>
    [JsonPropertyName("value")]
    public List<ShiftBetaModel> Value { get; set; }
}
