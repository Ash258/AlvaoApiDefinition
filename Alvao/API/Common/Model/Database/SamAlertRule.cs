using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notification rules.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html"/>
[Table("dbo.SamAlertRule")]
public class SamAlertRule {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_Active"/>
    public virtual bool Active { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_AlertAfterDays"/>
    public virtual int? AlertAfterDays { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_AlertRoleId"/>
    public virtual int? AlertRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_AlertSuperior"/>
    public virtual bool AlertSuperior { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_AlertSwManager"/>
    public virtual bool AlertSwManager { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertRule.html#Alvao_API_Common_Model_Database_SamAlertRule_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
