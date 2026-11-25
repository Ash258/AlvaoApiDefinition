using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Notice for unresolved tickets - other recipients.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html"/>
[Table("dbo.SlaAlertRuleReceiver")]
public class SlaAlertRuleReceiver {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html#Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html#Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html#Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_SlaAlertRuleId"/>
    /// <remarks>Column <c>SlaAlertRuleId</c>: int, not null. References <see cref="tSlaAlertRule"/>.</remarks>
    public virtual int SlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html#Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
