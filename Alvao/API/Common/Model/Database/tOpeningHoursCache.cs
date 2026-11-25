using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Auxiliary records for optimizing time calculations according to service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html"/>
[Table("dbo.tOpeningHoursCache")]
public class tOpeningHoursCache {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html#Alvao_API_Common_Model_Database_tOpeningHoursCache_dFrom"/>
    /// <remarks>Column <c>dFrom</c>: datetime, not null.</remarks>
    [ExplicitKey]
    public virtual DateTime dFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html#Alvao_API_Common_Model_Database_tOpeningHoursCache_dTo"/>
    /// <remarks>Column <c>dTo</c>: datetime, not null.</remarks>
    [ExplicitKey]
    public virtual DateTime dTo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html#Alvao_API_Common_Model_Database_tOpeningHoursCache_liOpeningHoursId"/>
    /// <remarks>Column <c>liOpeningHoursId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html#Alvao_API_Common_Model_Database_tOpeningHoursCache_nTotalDays"/>
    /// <remarks>Column <c>nTotalDays</c>: float, not null.</remarks>
    [ExplicitKey]
    public virtual double nTotalDays { get; set; }
}
