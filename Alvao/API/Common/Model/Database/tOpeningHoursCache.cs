using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Auxiliary records for optimizing time calculations according to service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html"/>
[Table("dbo.tOpeningHoursCache")]
public class tOpeningHoursCache {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html#Alvao_API_Common_Model_Database_tOpeningHoursCache_dFrom"/>
    public virtual DateTime dFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html#Alvao_API_Common_Model_Database_tOpeningHoursCache_dTo"/>
    public virtual DateTime dTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html#Alvao_API_Common_Model_Database_tOpeningHoursCache_liOpeningHoursId"/>
    [ExplicitKey]
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursCache.html#Alvao_API_Common_Model_Database_tOpeningHoursCache_nTotalDays"/>
    public virtual double nTotalDays { get; set; }
}
