using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Service operating hours.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tOpeningHours.htm"/>
[TableAttribute("dbo.tOpeningHours")]
public class tOpeningHours
{
    /// <summary>End of the current operating hours interval.</summary>
    public virtual DateTime? ActualOpeningHoursEnd { get; set; }
    /// <summary>Public holiday region. A foreign key on the tBankHolidayRegion table.</summary>
    public virtual int? BankHolidayRegionId { get; set; }
    [KeyAttribute]
    public virtual int iOpeningHoursId { get; set; }
    public virtual string mDescription { get; set; }
    public virtual string mNotes { get; set; }
    /// <summary>Beginning of the next operating hours interval.</summary>
    public virtual DateTime? NextOpeningHoursStart { get; set; }
    public virtual string sOpeningHours { get; set; }
    public virtual int? TimeZoneId { get; set; }

    public tOpeningHours() { }
}
