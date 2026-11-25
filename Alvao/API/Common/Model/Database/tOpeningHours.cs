using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html"/>
[Table("dbo.tOpeningHours")]
public class tOpeningHours {
    /// <summary>End of the current operating hours interval.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_ActualOpeningHoursEnd"/>
    /// <remarks>Column <c>ActualOpeningHoursEnd</c>: datetime, null.</remarks>
    public virtual DateTime? ActualOpeningHoursEnd { get; set; }
    /// <summary>Public holiday region. A foreign key on the tBankHolidayRegion table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_BankHolidayRegionId"/>
    /// <remarks>Column <c>BankHolidayRegionId</c>: int, null. References <see cref="tBankHolidayRegion"/>.</remarks>
    public virtual int? BankHolidayRegionId { get; set; }
    /// <summary>Beginning of the next operating hours interval.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_NextOpeningHoursStart"/>
    /// <remarks>Column <c>NextOpeningHoursStart</c>: datetime, null.</remarks>
    public virtual DateTime? NextOpeningHoursStart { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_TimeZoneId"/>
    /// <remarks>Column <c>TimeZoneId</c>: int, null. References <see cref="TimeZone"/>.</remarks>
    public virtual int? TimeZoneId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_iOpeningHoursId"/>
    /// <remarks>Column <c>iOpeningHoursId</c>: int, not null.</remarks>
    [Key]
    public virtual int iOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_mDescription"/>
    /// <remarks>Column <c>mDescription</c>: nvarchar(max), null.</remarks>
    public virtual string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_mNotes"/>
    /// <remarks>Column <c>mNotes</c>: nvarchar(max), null.</remarks>
    public virtual string mNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_sOpeningHours"/>
    /// <remarks>Column <c>sOpeningHours</c>: nvarchar(255), null.</remarks>
    public virtual string sOpeningHours { get; set; }
}
