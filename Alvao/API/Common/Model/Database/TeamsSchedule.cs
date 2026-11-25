using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Solvers schedules imported from MS Teams.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsSchedule.html"/>
[Table("dbo.TeamsSchedule")]
public class TeamsSchedule {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsSchedule.html#Alvao_API_Common_Model_Database_TeamsSchedule_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Last update timestamp (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsSchedule.html#Alvao_API_Common_Model_Database_TeamsSchedule_LastUpdate"/>
    public virtual DateTime LastUpdate { get; set; }
    /// <summary>Person ID (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsSchedule.html#Alvao_API_Common_Model_Database_TeamsSchedule_PersonId"/>
    public virtual int PersonId { get; set; }
}
