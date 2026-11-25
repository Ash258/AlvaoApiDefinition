using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notification rules.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html"/>
[Table("dbo.SamAlertRule")]
public class SamAlertRule {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_Active"/>
    /// <remarks>Column <c>Active</c>: bit, not null.</remarks>
    public virtual bool Active { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_AlertAfterDays"/>
    /// <remarks>Column <c>AlertAfterDays</c>: int, null.</remarks>
    public virtual int? AlertAfterDays { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_AlertRoleId"/>
    /// <remarks>Column <c>AlertRoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? AlertRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_AlertSuperior"/>
    /// <remarks>Column <c>AlertSuperior</c>: bit, not null.</remarks>
    public virtual bool AlertSuperior { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_AlertSwManager"/>
    /// <remarks>Column <c>AlertSwManager</c>: bit, not null.</remarks>
    public virtual bool AlertSwManager { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int id { get; set; }
}
