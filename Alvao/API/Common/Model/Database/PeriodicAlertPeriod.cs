using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Send period of periodic alerts.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlertPeriod.html"/>
[Table("dbo.PeriodicAlertPeriod")]
public class PeriodicAlertPeriod {
    /// <summary>Period name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlertPeriod.html#Alvao_API_Common_Model_Database_PeriodicAlertPeriod_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlertPeriod.html#Alvao_API_Common_Model_Database_PeriodicAlertPeriod_id"/>
    [ExplicitKey]
    public virtual byte id { get; set; }
}
