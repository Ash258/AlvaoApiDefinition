using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Employee labor contracts.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html"/>
[Table("dbo.tWorkLoad")]
public class tWorkLoad {
    /// <summary>Labor contract end date + 1 (UTC). NULL represents a labor contract for an indefinite period.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_dEnd"/>
    /// <remarks>Column <c>dEnd</c>: datetime, null.</remarks>
    public virtual DateTime? dEnd { get; set; }
    /// <summary>Labor contract start date (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_dStart"/>
    /// <remarks>Column <c>dStart</c>: datetime, not null.</remarks>
    public virtual DateTime dStart { get; set; }
    /// <summary>Number of work hours per day.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_iWorkHoursPerDay"/>
    /// <remarks>Column <c>iWorkHoursPerDay</c>: float, not null.</remarks>
    public virtual double iWorkHoursPerDay { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_iWorkLoadId"/>
    /// <remarks>Column <c>iWorkLoadId</c>: int, not null.</remarks>
    [Key]
    public virtual int iWorkLoadId { get; set; }
    /// <summary>ID of the person assigned this labor contract</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tWorkLoad.html#Alvao_API_Common_Model_Database_tWorkLoad_liPersonId"/>
    /// <remarks>Column <c>liPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int liPersonId { get; set; }
}
