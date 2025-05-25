using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of SLAs in all used languages.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html"/>
[Table("dbo.vSlaLoc")]
public class vSlaLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_LocalizedSla"/>
    public virtual string LocalizedSla { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_LocalizedSlaDesc"/>
    public virtual string LocalizedSlaDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_Pause"/>
    public virtual bool Pause { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_SlaLocaleId"/>
    public virtual int SlaLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_dSlaRemoved"/>
    public virtual DateTime? dSlaRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_iSlaId"/>
    public virtual int iSlaId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_liOpeningHoursId"/>
    public virtual int? liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_mSlaDesc"/>
    public virtual string mSlaDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_mSlaNotes"/>
    public virtual string mSlaNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_nSlaDeadlineHours"/>
    public virtual double? nSlaDeadlineHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_nSlaQuality"/>
    public virtual double? nSlaQuality { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_nSlaReactionHours"/>
    public virtual double? nSlaReactionHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_sSla"/>
    public virtual string sSla { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaLoc.html#Alvao_API_Common_Model_Database_vSlaLoc_sSlaContract"/>
    public virtual string sSlaContract { get; set; }
}
