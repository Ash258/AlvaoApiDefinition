using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Notice for unresolved tickets - other recipients.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SlaAlertRuleReceiver.htm"/>
[TableAttribute("dbo.SlaAlertRuleReceiver")]
public class SlaAlertRuleReceiver
{
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual int? PersonId { get; set; }
    public virtual int? RoleId { get; set; }
    public virtual int SlaAlertRuleId { get; set; }

    public SlaAlertRuleReceiver() { }
}
