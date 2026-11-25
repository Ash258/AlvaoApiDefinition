using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Solvers schedules imported from MS Teams.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsSchedule.html"/>
[Table("dbo.TeamsSchedule")]
public class TeamsSchedule {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsSchedule.html#Alvao_API_Common_Model_Database_TeamsSchedule_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Last update timestamp (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsSchedule.html#Alvao_API_Common_Model_Database_TeamsSchedule_LastUpdate"/>
    /// <remarks>Column <c>LastUpdate</c>: datetime, not null.</remarks>
    public virtual DateTime LastUpdate { get; set; }
    /// <summary>Person ID (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsSchedule.html#Alvao_API_Common_Model_Database_TeamsSchedule_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
}
