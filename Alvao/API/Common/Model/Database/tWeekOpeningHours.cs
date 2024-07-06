using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Item in the definition of service operating hours.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tWeekOpeningHours.htm"/>
[TableAttribute("dbo.tWeekOpeningHours")]
public class tWeekOpeningHours
{
    public virtual bool bFriday { get; set; }
    public virtual bool bMonday { get; set; }
    public virtual bool bSaturday { get; set; }
    public virtual bool bSunday { get; set; }
    public virtual bool bThursday { get; set; }
    public virtual bool bTuesday { get; set; }
    public virtual bool bWednesday { get; set; }
    public virtual DateTime? dInvalidSince { get; set; }
    public virtual DateTime dValidSince { get; set; }
    [KeyAttribute]
    public virtual int iWeekOpeningHoursId { get; set; }
    public virtual int liOpeningHoursId { get; set; }
    public virtual double nClosingHour { get; set; }
    public virtual double nOpeningHour { get; set; }

    public tWeekOpeningHours() { }
}
