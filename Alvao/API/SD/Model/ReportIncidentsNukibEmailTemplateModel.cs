using System.Text.Json.Serialization;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ReportIncidentsNukibEmailTemplateModel.html"/>
public class ReportIncidentsNukibEmailTemplateModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ReportIncidentsNukibEmailTemplateModel.html#Alvao_API_SD_Model_ReportIncidentsNukibEmailTemplateModel_Csy"/>
    [JsonPropertyName("csy")]
    public IncidentReportLocalization Csy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ReportIncidentsNukibEmailTemplateModel.html#Alvao_API_SD_Model_ReportIncidentsNukibEmailTemplateModel_Enu"/>
    [JsonPropertyName("enu")]
    public IncidentReportLocalization Enu { get; set; }
}
