using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Solvers shifts imported from MS Teams.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsShift.html"/>
[Table("dbo.TeamsShift")]
public class TeamsShift {
    /// <summary>End of the shift (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsShift.html#Alvao_API_Common_Model_Database_TeamsShift_End"/>
    /// <remarks>Column <c>End</c>: datetime, not null.</remarks>
    public virtual DateTime End { get; set; }
    /// <summary>Shift ID in Graph API.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsShift.html#Alvao_API_Common_Model_Database_TeamsShift_GraphShiftId"/>
    /// <remarks>Column <c>GraphShiftId</c>: nvarchar(255), not null.</remarks>
    public virtual string GraphShiftId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsShift.html#Alvao_API_Common_Model_Database_TeamsShift_Id"/>
    /// <remarks>Column <c>Id</c>: bigint, not null.</remarks>
    [Key]
    public virtual long Id { get; set; }
    /// <summary>Start of the shift (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsShift.html#Alvao_API_Common_Model_Database_TeamsShift_Start"/>
    /// <remarks>Column <c>Start</c>: datetime, not null.</remarks>
    public virtual DateTime Start { get; set; }
    /// <summary>Teams schedule ID (TeamsSchedule.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TeamsShift.html#Alvao_API_Common_Model_Database_TeamsShift_TeamsScheduleId"/>
    /// <remarks>Column <c>TeamsScheduleId</c>: int, not null. References <see cref="TeamsSchedule"/>.</remarks>
    public virtual int TeamsScheduleId { get; set; }
}
