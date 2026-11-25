using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Solvers calendars imported from MS Outlook.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html"/>
[Table("dbo.Calendar")]
public class Calendar {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Last update timestamp (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_LastUpdate"/>
    public virtual DateTime LastUpdate { get; set; }
    /// <summary>OData link to the next delta.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_ODataDeltaLink"/>
    public virtual string ODataDeltaLink { get; set; }
    /// <summary>OData link window end timestamp (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_ODataDeltaLinkEnd"/>
    public virtual DateTime? ODataDeltaLinkEnd { get; set; }
    /// <summary>OData link window start timestamp (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_ODataDeltaLinkStart"/>
    public virtual DateTime? ODataDeltaLinkStart { get; set; }
    /// <summary>Person ID (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Calendar.html#Alvao_API_Common_Model_Database_Calendar_PersonId"/>
    public virtual int PersonId { get; set; }
}
