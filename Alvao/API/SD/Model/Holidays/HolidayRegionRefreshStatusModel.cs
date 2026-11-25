namespace Alvao.API.SD.Model.Holidays;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayRegionRefreshStatusModel.html"/>
public sealed class HolidayRegionRefreshStatusModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayRegionRefreshStatusModel.html#Alvao_API_SD_Model_Holidays_HolidayRegionRefreshStatusModel_Reason"/>
    public HolidayRegionRefreshStatusReason Reason { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayRegionRefreshStatusModel.html#Alvao_API_SD_Model_Holidays_HolidayRegionRefreshStatusModel_RequiresRefresh"/>
    public bool RequiresRefresh { get; set; }
}
