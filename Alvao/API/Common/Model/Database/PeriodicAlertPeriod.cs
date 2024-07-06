using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Send period of periodic alerts.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PeriodicAlertPeriod.htm"/>
[TableAttribute("dbo.PeriodicAlertPeriod")]
public class PeriodicAlertPeriod
{
    /// <summary>Record ID</summary>
    [ExplicitKeyAttribute]
    public virtual byte id { get; set; }
    /// <summary>Period name</summary>
    public virtual string Name { get; set; }

    public PeriodicAlertPeriod() { }
}
