using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Time zone shifts compared to UTC for each year
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TimeZoneBias.htm"/>
[TableAttribute("dbo.TimeZoneBias")]
public class TimeZoneBias
{
    /// <summary>Shift compared to UTC in minutes.</summary>
    public virtual int Bias { get; set; }
    /// <summary>From date.</summary>
    public virtual DateTime? FromDate { get; set; }
    /// <summary>Link to time zone.</summary>
    [ExplicitKeyAttribute]
    public virtual int TimeZoneId { get; set; }
    /// <summary>Until.</summary>
    public virtual DateTime? ToDate { get; set; }

    public TimeZoneBias() { }
}
