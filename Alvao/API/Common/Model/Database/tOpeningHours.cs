using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html"/>
[Table("dbo.tOpeningHours")]
public class tOpeningHours {
    /// <summary>End of the current operating hours interval.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_ActualOpeningHoursEnd"/>
    public virtual DateTime? ActualOpeningHoursEnd { get; set; }
    /// <summary>Public holiday region. A foreign key on the tBankHolidayRegion table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_BankHolidayRegionId"/>
    public virtual int? BankHolidayRegionId { get; set; }
    /// <summary>Beginning of the next operating hours interval.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_NextOpeningHoursStart"/>
    public virtual DateTime? NextOpeningHoursStart { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_TimeZoneId"/>
    public virtual int? TimeZoneId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_iOpeningHoursId"/>
    [Key]
    public virtual int iOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_mDescription"/>
    public virtual string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_mNotes"/>
    public virtual string mNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHours.html#Alvao_API_Common_Model_Database_tOpeningHours_sOpeningHours"/>
    public virtual string sOpeningHours { get; set; }
}
