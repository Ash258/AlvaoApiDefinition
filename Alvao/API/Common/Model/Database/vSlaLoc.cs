using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of SLAs in all used languages.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaLoc.htm"/>
[TableAttribute("dbo.vSlaLoc")]
public class vSlaLoc
{
    public virtual DateTime? dSlaRemoved { get; set; }
    public virtual int iSlaId { get; set; }
    public virtual int? liOpeningHoursId { get; set; }
    public virtual string LocalizedSla { get; set; }
    public virtual string LocalizedSlaDesc { get; set; }
    public virtual string mSlaDesc { get; set; }
    public virtual string mSlaNotes { get; set; }
    public virtual double? nSlaDeadlineHours { get; set; }
    public virtual double? nSlaQuality { get; set; }
    public virtual double? nSlaReactionHours { get; set; }
    public virtual bool Pause { get; set; }
    public virtual int SlaLocaleId { get; set; }
    public virtual string sSla { get; set; }
    public virtual string sSlaContract { get; set; }

    public vSlaLoc() { }
}
