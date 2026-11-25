using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Events in solvers calendars imported from MS Outlook.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html"/>
[Table("dbo.CalendarEvent")]
public class CalendarEvent {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.ShowAs.html#fields"/>
    public enum ShowAs {
        Unknown = 1,
        Free = 2,
        Tentative = 3,
        Busy = 4,
        OutOfOffice = 5,
        WorkingElsewhere = 6,
    }

    /// <summary>Calendar ID (Calendar.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_CalendarId"/>
    /// <remarks>Column <c>CalendarId</c>: int, not null. References <see cref="Calendar"/>.</remarks>
    public virtual int CalendarId { get; set; }
    /// <summary>End of the event (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_End"/>
    /// <remarks>Column <c>End</c>: datetime, not null.</remarks>
    public virtual DateTime End { get; set; }
    /// <summary>Event ID in Graph API.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_GraphEventId"/>
    /// <remarks>Column <c>GraphEventId</c>: nvarchar(255), not null.</remarks>
    public virtual string GraphEventId { get; set; }
    /// <summary>ID of the series master event in Graph API.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_GraphSeriesMasterId"/>
    /// <remarks>Column <c>GraphSeriesMasterId</c>: nvarchar(255), null.</remarks>
    public virtual string GraphSeriesMasterId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_Id"/>
    /// <remarks>Column <c>Id</c>: bigint, not null.</remarks>
    [Key]
    public virtual long Id { get; set; }
    /// <summary>Indicates whether the event lasts all day.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_IsAllDay"/>
    /// <remarks>Column <c>IsAllDay</c>: bit, not null.</remarks>
    public virtual bool IsAllDay { get; set; }
    /// <summary>Availability status of the event (CalendarEventShowAs.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_ShowAsId"/>
    /// <remarks>Column <c>ShowAsId</c>: tinyint, not null. References <see cref="CalendarEventShowAs"/>.</remarks>
    public virtual byte ShowAsId { get; set; }
    /// <summary>Start of the event (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_Start"/>
    /// <remarks>Column <c>Start</c>: datetime, not null.</remarks>
    public virtual DateTime Start { get; set; }
}
