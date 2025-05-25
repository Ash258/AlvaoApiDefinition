using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Employee labor contracts.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html"/>
[Table("dbo.tWorkLoad")]
public class tWorkLoad {
    /// <summary>Labor contract end date + 1 (UTC). NULL represents a labor contract for an indefinite period.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_dEnd"/>
    public virtual DateTime? dEnd { get; set; }
    /// <summary>Labor contract start date (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_dStart"/>
    public virtual DateTime dStart { get; set; }
    /// <summary>Number of work hours per day.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_iWorkHoursPerDay"/>
    public virtual double iWorkHoursPerDay { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_iWorkLoadId"/>
    [Key]
    public virtual int iWorkLoadId { get; set; }
    /// <summary>ID of the person assigned this labor contract</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_liPersonId"/>
    public virtual int liPersonId { get; set; }
}
