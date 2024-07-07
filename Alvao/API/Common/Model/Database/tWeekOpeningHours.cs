using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Item in the definition of service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tWeekOpeningHours.htm"/>
[TableAttribute("dbo.tWeekOpeningHours")]
public class tWeekOpeningHours
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_bFriday.htm"/>
    public virtual bool bFriday { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_bMonday.htm"/>
    public virtual bool bMonday { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_bSaturday.htm"/>
    public virtual bool bSaturday { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_bSunday.htm"/>
    public virtual bool bSunday { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_bThursday.htm"/>
    public virtual bool bThursday { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_bTuesday.htm"/>
    public virtual bool bTuesday { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_bWednesday.htm"/>
    public virtual bool bWednesday { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_dInvalidSince.htm"/>
    public virtual DateTime? dInvalidSince { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_dValidSince.htm"/>
    public virtual DateTime dValidSince { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_iWeekOpeningHoursId.htm"/>
    [KeyAttribute]
    public virtual int iWeekOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_liOpeningHoursId.htm"/>
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_nClosingHour.htm"/>
    public virtual double nClosingHour { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWeekOpeningHours_nOpeningHour.htm"/>
    public virtual double nOpeningHour { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tWeekOpeningHours__ctor.htm"/>
    public tWeekOpeningHours() { }
}
