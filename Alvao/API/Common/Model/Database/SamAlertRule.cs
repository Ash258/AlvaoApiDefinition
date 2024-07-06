using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SAM notification rules.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SamAlertRule.htm"/>
[TableAttribute("dbo.SamAlertRule")]
public class SamAlertRule
{
    public virtual bool Active { get; set; }
    public virtual int? AlertAfterDays { get; set; }
    public virtual int? AlertRoleId { get; set; }
    public virtual bool AlertSuperior { get; set; }
    public virtual bool AlertSwManager { get; set; }
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public SamAlertRule() { }
}
