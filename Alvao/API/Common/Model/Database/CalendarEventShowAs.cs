using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Availability statuses of the calendar event.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEventShowAs.html"/>
[Table("dbo.CalendarEventShowAs")]
public class CalendarEventShowAs {
    /// <summary>
    /// Record ID: 1 - Unknown 2 - Free 3 - Tentative 4 - Busy 5 - Out of office 6 - Working elsewhere
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEventShowAs.html#Alvao_API_Common_Model_Database_CalendarEventShowAs_Id"/>
    [ExplicitKey]
    public virtual byte Id { get; set; }
    /// <summary>Name of the status.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.CalendarEventShowAs.html#Alvao_API_Common_Model_Database_CalendarEventShowAs_Name"/>
    public virtual string Name { get; set; }
}
