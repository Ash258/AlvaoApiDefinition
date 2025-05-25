using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Item in the definition of service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html"/>
[Table("dbo.tWeekOpeningHours")]
public class tWeekOpeningHours {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bFriday"/>
    public virtual bool bFriday { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bMonday"/>
    public virtual bool bMonday { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bSaturday"/>
    public virtual bool bSaturday { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bSunday"/>
    public virtual bool bSunday { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bThursday"/>
    public virtual bool bThursday { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bTuesday"/>
    public virtual bool bTuesday { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_bWednesday"/>
    public virtual bool bWednesday { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_dInvalidSince"/>
    public virtual DateTime? dInvalidSince { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_dValidSince"/>
    public virtual DateTime dValidSince { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_iWeekOpeningHoursId"/>
    [Key]
    public virtual int iWeekOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_liOpeningHoursId"/>
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_nClosingHour"/>
    public virtual double nClosingHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWeekOpeningHours.html#Alvao_API_Common_Model_Database_tWeekOpeningHours_nOpeningHour"/>
    public virtual double nOpeningHour { get; set; }
}
