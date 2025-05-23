using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Send period of periodic alerts.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PeriodicAlertPeriod.htm"/>
[TableAttribute("dbo.PeriodicAlertPeriod")]
public class PeriodicAlertPeriod {
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PeriodicAlertPeriod_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual byte id { get; set; }
    /// <summary>Period name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PeriodicAlertPeriod_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_PeriodicAlertPeriod__ctor.htm"/>
    public PeriodicAlertPeriod() { }
}
