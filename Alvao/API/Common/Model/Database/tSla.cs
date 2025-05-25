using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SLA.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html"/>
[Table("dbo.tSla")]
public class tSla {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_Pause"/>
    public virtual bool Pause { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_dSlaRemoved"/>
    public virtual DateTime? dSlaRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_iSlaId"/>
    [Key]
    public virtual int iSlaId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_liOpeningHoursId"/>
    public virtual int? liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_mSlaDesc"/>
    public virtual string mSlaDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_mSlaNotes"/>
    public virtual string mSlaNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_nSlaDeadlineHours"/>
    public virtual double? nSlaDeadlineHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_nSlaQuality"/>
    public virtual double? nSlaQuality { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_nSlaReactionHours"/>
    public virtual double? nSlaReactionHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_sSla"/>
    public virtual string sSla { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSla.html#Alvao_API_Common_Model_Database_tSla_sSlaContract"/>
    public virtual string sSlaContract { get; set; }
}
