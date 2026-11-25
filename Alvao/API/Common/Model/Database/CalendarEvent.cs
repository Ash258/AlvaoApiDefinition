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
    public virtual int CalendarId { get; set; }
    /// <summary>End of the event (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_End"/>
    public virtual DateTime End { get; set; }
    /// <summary>Event ID in Graph API.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_GraphEventId"/>
    public virtual string GraphEventId { get; set; }
    /// <summary>ID of the series master event in Graph API.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_GraphSeriesMasterId"/>
    public virtual string GraphSeriesMasterId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_Id"/>
    [Key]
    public virtual long Id { get; set; }
    /// <summary>Indicates whether the event lasts all day.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_IsAllDay"/>
    public virtual bool IsAllDay { get; set; }
    /// <summary>Availability status of the event (CalendarEventShowAs.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_ShowAsId"/>
    public virtual byte ShowAsId { get; set; }
    /// <summary>Start of the event (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEvent.html#Alvao_API_Common_Model_Database_CalendarEvent_Start"/>
    public virtual DateTime Start { get; set; }
}
