using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notification rules.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SamAlertRule.htm"/>
[TableAttribute("dbo.SamAlertRule")]
public class SamAlertRule
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertRule_Active.htm"/>
    public virtual bool Active { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertRule_AlertAfterDays.htm"/>
    public virtual int? AlertAfterDays { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertRule_AlertRoleId.htm"/>
    public virtual int? AlertRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertRule_AlertSuperior.htm"/>
    public virtual bool AlertSuperior { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertRule_AlertSwManager.htm"/>
    public virtual bool AlertSwManager { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertRule_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SamAlertRule__ctor.htm"/>
    public SamAlertRule() { }
}
