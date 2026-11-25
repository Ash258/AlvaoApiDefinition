using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Solvers calendars imported from MS Outlook.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html"/>
[Table("dbo.Calendar")]
public class Calendar {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Last update timestamp (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_LastUpdate"/>
    /// <remarks>Column <c>LastUpdate</c>: datetime, not null.</remarks>
    public virtual DateTime LastUpdate { get; set; }
    /// <summary>OData link to the next delta.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_ODataDeltaLink"/>
    /// <remarks>Column <c>ODataDeltaLink</c>: nvarchar(2048), null.</remarks>
    public virtual string ODataDeltaLink { get; set; }
    /// <summary>OData link window end timestamp (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_ODataDeltaLinkEnd"/>
    /// <remarks>Column <c>ODataDeltaLinkEnd</c>: datetime, null.</remarks>
    public virtual DateTime? ODataDeltaLinkEnd { get; set; }
    /// <summary>OData link window start timestamp (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_ODataDeltaLinkStart"/>
    /// <remarks>Column <c>ODataDeltaLinkStart</c>: datetime, null.</remarks>
    public virtual DateTime? ODataDeltaLinkStart { get; set; }
    /// <summary>Person ID (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
}
