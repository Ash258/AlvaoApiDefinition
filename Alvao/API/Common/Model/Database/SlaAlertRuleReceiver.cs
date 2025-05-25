using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Notice for unresolved tickets - other recipients.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html"/>
[Table("dbo.SlaAlertRuleReceiver")]
public class SlaAlertRuleReceiver {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html#Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html#Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html#Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_SlaAlertRuleId"/>
    public virtual int SlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaAlertRuleReceiver.html#Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_id"/>
    [Key]
    public virtual int id { get; set; }
}
