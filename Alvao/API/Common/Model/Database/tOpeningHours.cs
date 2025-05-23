using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tOpeningHours.htm"/>
[TableAttribute("dbo.tOpeningHours")]
public class tOpeningHours
{
    /// <summary>End of the current operating hours interval.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHours_ActualOpeningHoursEnd.htm"/>
    public virtual DateTime? ActualOpeningHoursEnd { get; set; }
    /// <summary>Public holiday region. A foreign key on the tBankHolidayRegion table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHours_BankHolidayRegionId.htm"/>
    public virtual int? BankHolidayRegionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHours_iOpeningHoursId.htm"/>
    [KeyAttribute]
    public virtual int iOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHours_mDescription.htm"/>
    public virtual string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHours_mNotes.htm"/>
    public virtual string mNotes { get; set; }
    /// <summary>Beginning of the next operating hours interval.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHours_NextOpeningHoursStart.htm"/>
    public virtual DateTime? NextOpeningHoursStart { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHours_sOpeningHours.htm"/>
    public virtual string sOpeningHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHours_TimeZoneId.htm"/>
    public virtual int? TimeZoneId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tOpeningHours__ctor.htm"/>
    public tOpeningHours() { }
}
