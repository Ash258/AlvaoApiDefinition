using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Send period of periodic alerts.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlertPeriod.html"/>
[Table("dbo.PeriodicAlertPeriod")]
public class PeriodicAlertPeriod {
    /// <summary>Period name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlertPeriod.html#Alvao_API_Common_Model_Database_PeriodicAlertPeriod_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlertPeriod.html#Alvao_API_Common_Model_Database_PeriodicAlertPeriod_id"/>
    /// <remarks>Column <c>id</c>: tinyint, not null.</remarks>
    [ExplicitKey]
    public virtual byte id { get; set; }
}
