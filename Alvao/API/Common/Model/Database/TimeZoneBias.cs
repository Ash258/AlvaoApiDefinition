using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Time zone shifts compared to UTC for each year</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html"/>
[Table("dbo.TimeZoneBias")]
public class TimeZoneBias {
    /// <summary>Shift compared to UTC in minutes.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html#Alvao_API_Common_Model_Database_TimeZoneBias_Bias"/>
    /// <remarks>Column <c>Bias</c>: int, not null.</remarks>
    public virtual int Bias { get; set; }
    /// <summary>From date.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html#Alvao_API_Common_Model_Database_TimeZoneBias_FromDate"/>
    /// <remarks>Column <c>FromDate</c>: datetime, null.</remarks>
    public virtual DateTime? FromDate { get; set; }
    /// <summary>Link to time zone.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html#Alvao_API_Common_Model_Database_TimeZoneBias_TimeZoneId"/>
    /// <remarks>Column <c>TimeZoneId</c>: int, not null. References <see cref="TimeZone"/>.</remarks>
    [ExplicitKey]
    public virtual int TimeZoneId { get; set; }
    /// <summary>Until.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html#Alvao_API_Common_Model_Database_TimeZoneBias_ToDate"/>
    /// <remarks>Column <c>ToDate</c>: datetime, null.</remarks>
    public virtual DateTime? ToDate { get; set; }
}
