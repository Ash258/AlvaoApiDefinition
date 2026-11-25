using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Item in the definition of service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html"/>
[Table("dbo.tWeekOpeningHours")]
public class tWeekOpeningHours {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bFriday"/>
    /// <remarks>Column <c>bFriday</c>: bit, not null.</remarks>
    public virtual bool bFriday { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bMonday"/>
    /// <remarks>Column <c>bMonday</c>: bit, not null.</remarks>
    public virtual bool bMonday { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bSaturday"/>
    /// <remarks>Column <c>bSaturday</c>: bit, not null.</remarks>
    public virtual bool bSaturday { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bSunday"/>
    /// <remarks>Column <c>bSunday</c>: bit, not null.</remarks>
    public virtual bool bSunday { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bThursday"/>
    /// <remarks>Column <c>bThursday</c>: bit, not null.</remarks>
    public virtual bool bThursday { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bTuesday"/>
    /// <remarks>Column <c>bTuesday</c>: bit, not null.</remarks>
    public virtual bool bTuesday { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bWednesday"/>
    /// <remarks>Column <c>bWednesday</c>: bit, not null.</remarks>
    public virtual bool bWednesday { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_dInvalidSince"/>
    /// <remarks>Column <c>dInvalidSince</c>: datetime, null.</remarks>
    public virtual DateTime? dInvalidSince { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_dValidSince"/>
    /// <remarks>Column <c>dValidSince</c>: datetime, not null.</remarks>
    public virtual DateTime dValidSince { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_iWeekOpeningHoursId"/>
    /// <remarks>Column <c>iWeekOpeningHoursId</c>: int, not null.</remarks>
    [Key]
    public virtual int iWeekOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_liOpeningHoursId"/>
    /// <remarks>Column <c>liOpeningHoursId</c>: int, not null. References <see cref="tOpeningHours"/>.</remarks>
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_nClosingHour"/>
    /// <remarks>Column <c>nClosingHour</c>: float, not null.</remarks>
    public virtual double nClosingHour { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_nOpeningHour"/>
    /// <remarks>Column <c>nOpeningHour</c>: float, not null.</remarks>
    public virtual double nOpeningHour { get; set; }
}
