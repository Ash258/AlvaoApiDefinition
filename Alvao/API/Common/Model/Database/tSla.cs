using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SLA.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html"/>
[Table("dbo.tSla")]
public class tSla {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_Pause"/>
    /// <remarks>Column <c>Pause</c>: bit, not null.</remarks>
    public virtual bool Pause { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_dSlaRemoved"/>
    /// <remarks>Column <c>dSlaRemoved</c>: datetime, null.</remarks>
    public virtual DateTime? dSlaRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_iSlaId"/>
    /// <remarks>Column <c>iSlaId</c>: int, not null.</remarks>
    [Key]
    public virtual int iSlaId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_liOpeningHoursId"/>
    /// <remarks>Column <c>liOpeningHoursId</c>: int, null. References <see cref="tOpeningHours"/>.</remarks>
    public virtual int? liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_mSlaDesc"/>
    /// <remarks>Column <c>mSlaDesc</c>: nvarchar(max), null.</remarks>
    public virtual string mSlaDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_mSlaNotes"/>
    /// <remarks>Column <c>mSlaNotes</c>: nvarchar(max), null.</remarks>
    public virtual string mSlaNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_nSlaDeadlineHours"/>
    /// <remarks>Column <c>nSlaDeadlineHours</c>: float, null.</remarks>
    public virtual double? nSlaDeadlineHours { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_nSlaQuality"/>
    /// <remarks>Column <c>nSlaQuality</c>: float, null.</remarks>
    public virtual double? nSlaQuality { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_nSlaReactionHours"/>
    /// <remarks>Column <c>nSlaReactionHours</c>: float, null.</remarks>
    public virtual double? nSlaReactionHours { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_sSla"/>
    /// <remarks>Column <c>sSla</c>: nvarchar(255), null.</remarks>
    public virtual string sSla { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_sSlaContract"/>
    /// <remarks>Column <c>sSlaContract</c>: nvarchar(255), null.</remarks>
    public virtual string sSlaContract { get; set; }
}
