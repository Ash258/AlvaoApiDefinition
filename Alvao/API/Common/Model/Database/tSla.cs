using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SLA.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSla.htm"/>
[TableAttribute("dbo.tSla")]
public class tSla
{
    public virtual DateTime? dSlaRemoved { get; set; }
    [KeyAttribute]
    public virtual int iSlaId { get; set; }
    public virtual int? liOpeningHoursId { get; set; }
    public virtual string mSlaDesc { get; set; }
    public virtual string mSlaNotes { get; set; }
    public virtual double? nSlaDeadlineHours { get; set; }
    public virtual double? nSlaQuality { get; set; }
    public virtual double? nSlaReactionHours { get; set; }
    public virtual bool Pause { get; set; }
    public virtual string sSla { get; set; }
    public virtual string sSlaContract { get; set; }

    public tSla() { }
}
