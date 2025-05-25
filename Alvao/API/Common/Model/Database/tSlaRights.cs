using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Assigning SLA to individuals and groups.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html"/>
[Table("dbo.tSlaRights")]
public class tSlaRights {
    /// <summary>1 = SLA is set as the default; 0 = SLA is not default</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_bSlaRightsDefault"/>
    public virtual bool bSlaRightsDefault { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_iSlaRightsId"/>
    [Key]
    public virtual int iSlaRightsId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_liHdSectionId"/>
    public virtual int liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsPersonId"/>
    public virtual int? liSlaRightsPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsRoleId"/>
    public virtual int? liSlaRightsRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsSlaId"/>
    public virtual int liSlaRightsSlaId { get; set; }
}
