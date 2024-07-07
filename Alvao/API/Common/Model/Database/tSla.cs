using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SLA.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSla.htm"/>
[TableAttribute("dbo.tSla")]
public class tSla
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_dSlaRemoved.htm"/>
    public virtual DateTime? dSlaRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_iSlaId.htm"/>
    [KeyAttribute]
    public virtual int iSlaId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_liOpeningHoursId.htm"/>
    public virtual int? liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_mSlaDesc.htm"/>
    public virtual string mSlaDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_mSlaNotes.htm"/>
    public virtual string mSlaNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_nSlaDeadlineHours.htm"/>
    public virtual double? nSlaDeadlineHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_nSlaQuality.htm"/>
    public virtual double? nSlaQuality { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_nSlaReactionHours.htm"/>
    public virtual double? nSlaReactionHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_Pause.htm"/>
    public virtual bool Pause { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_sSla.htm"/>
    public virtual string sSla { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSla_sSlaContract.htm"/>
    public virtual string sSlaContract { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSla__ctor.htm"/>
    public tSla() { }
}
