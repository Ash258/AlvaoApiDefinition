namespace Alvao.API.SD.Model.Holidays;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Holidays.HolidayRegionRefreshStatusReason.html"/>
public enum HolidayRegionRefreshStatusReason {
    CustomRegion = 2,
    NoRegionSelected = 0,
    NotLoaded = 3,
    Outdated = 4,
    RegionNotFound = 1,
    UpToDate = 5,
}
