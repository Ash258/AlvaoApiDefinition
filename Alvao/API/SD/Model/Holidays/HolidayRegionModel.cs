using System.Text.Json.Serialization;

namespace Alvao.API.SD.Model.Holidays;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayRegionModel.html"/>
public sealed class HolidayRegionModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayRegionModel.html#Alvao_API_SD_Model_Holidays_HolidayRegionModel_CountryCode"/>
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayRegionModel.html#Alvao_API_SD_Model_Holidays_HolidayRegionModel_Name"/>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
