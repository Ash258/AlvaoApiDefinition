using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Notice for unresolved tickets - other recipients.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SlaAlertRuleReceiver.htm"/>
[TableAttribute("dbo.SlaAlertRuleReceiver")]
public class SlaAlertRuleReceiver {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_RoleId.htm"/>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaAlertRuleReceiver_SlaAlertRuleId.htm"/>
    public virtual int SlaAlertRuleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SlaAlertRuleReceiver__ctor.htm"/>
    public SlaAlertRuleReceiver() { }
}
