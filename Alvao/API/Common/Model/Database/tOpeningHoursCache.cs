using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Auxiliary records for optimizing time calculations according to service operating hours.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tOpeningHoursCache.htm"/>
[TableAttribute("dbo.tOpeningHoursCache")]
public class tOpeningHoursCache
{
    public virtual DateTime dFrom { get; set; }
    public virtual DateTime dTo { get; set; }
    [ExplicitKeyAttribute]
    public virtual int liOpeningHoursId { get; set; }
    public virtual double nTotalDays { get; set; }

    public tOpeningHoursCache() { }
}
