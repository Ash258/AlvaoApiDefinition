using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Assigning SLA to individuals and groups.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html"/>
[Table("dbo.tSlaRights")]
public class tSlaRights {
    /// <summary>1 = SLA is set as the default; 0 = SLA is not default</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_bSlaRightsDefault"/>
    /// <remarks>Column <c>bSlaRightsDefault</c>: bit, not null.</remarks>
    public virtual bool bSlaRightsDefault { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_iSlaRightsId"/>
    /// <remarks>Column <c>iSlaRightsId</c>: int, not null.</remarks>
    [Key]
    public virtual int iSlaRightsId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_liHdSectionId"/>
    /// <remarks>Column <c>liHdSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsPersonId"/>
    /// <remarks>Column <c>liSlaRightsPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liSlaRightsPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsRoleId"/>
    /// <remarks>Column <c>liSlaRightsRoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? liSlaRightsRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSlaRights.html#Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsSlaId"/>
    /// <remarks>Column <c>liSlaRightsSlaId</c>: int, not null. References <see cref="tSla"/>.</remarks>
    public virtual int liSlaRightsSlaId { get; set; }
}
