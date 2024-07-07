using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Auxiliary records for optimizing time calculations according to service operating hours.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tOpeningHoursCache.htm"/>
[TableAttribute("dbo.tOpeningHoursCache")]
public class tOpeningHoursCache
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursCache_dFrom.htm"/>
    public virtual DateTime dFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursCache_dTo.htm"/>
    public virtual DateTime dTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursCache_liOpeningHoursId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursCache_nTotalDays.htm"/>
    public virtual double nTotalDays { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tOpeningHoursCache__ctor.htm"/>
    public tOpeningHoursCache() { }
}
