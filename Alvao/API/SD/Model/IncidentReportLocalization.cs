using System.Text.Json.Serialization;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.IncidentReportLocalization.html"/>
public class IncidentReportLocalization {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.IncidentReportLocalization.html#Alvao_API_SD_Model_IncidentReportLocalization_Body"/>
    [JsonPropertyName("body")]
    public string Body { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.IncidentReportLocalization.html#Alvao_API_SD_Model_IncidentReportLocalization_Subject"/>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }
}
