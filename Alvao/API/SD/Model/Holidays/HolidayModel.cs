using System.Text.Json.Serialization;

namespace Alvao.API.SD.Model.Holidays;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayModel.html"/>
public sealed class HolidayModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayModel.html#Alvao_API_SD_Model_Holidays_HolidayModel_CountryCode"/>
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayModel.html#Alvao_API_SD_Model_Holidays_HolidayModel_Date"/>
    [JsonPropertyName("date")]
    public DateOnly Date { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayModel.html#Alvao_API_SD_Model_Holidays_HolidayModel_Name"/>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
