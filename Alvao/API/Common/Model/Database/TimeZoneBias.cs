using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Time zone shifts compared to UTC for each year</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html"/>
[Table("dbo.TimeZoneBias")]
public class TimeZoneBias {
    /// <summary>Shift compared to UTC in minutes.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html#Alvao_API_Common_Model_Database_TimeZoneBias_Bias"/>
    public virtual int Bias { get; set; }
    /// <summary>From date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html#Alvao_API_Common_Model_Database_TimeZoneBias_FromDate"/>
    public virtual DateTime? FromDate { get; set; }
    /// <summary>Link to time zone.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html#Alvao_API_Common_Model_Database_TimeZoneBias_TimeZoneId"/>
    [ExplicitKey]
    public virtual int TimeZoneId { get; set; }
    /// <summary>Until.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZoneBias.html#Alvao_API_Common_Model_Database_TimeZoneBias_ToDate"/>
    public virtual DateTime? ToDate { get; set; }
}
