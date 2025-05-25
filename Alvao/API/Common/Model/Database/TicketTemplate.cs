using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of ticket templates</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html"/>
[Table("dbo.TicketTemplate")]
public class TicketTemplate {
    /// <summary>Daily (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Daily"/>
    public virtual bool Daily { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_DailyAfterClosing"/>
    public virtual int? DailyAfterClosing { get; set; }
    /// <summary>On weekdays (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_DailyEveryWeekday"/>
    public virtual bool DailyEveryWeekday { get; set; }
    /// <summary>Repetition period in days.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_DailyEveryXDays"/>
    public virtual int? DailyEveryXDays { get; set; }
    /// <summary>Description of template.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Number of occurrences upon which planning is finished.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_EndAfter"/>
    public virtual int? EndAfter { get; set; }
    /// <summary>End of repetition - only the date of the last available creation (you cannot work with time).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_EndDate"/>
    public virtual DateTime? EndDate { get; set; }
    /// <summary>ID of service in which the template is created.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_HdSectionId"/>
    public virtual int HdSectionId { get; set; }
    /// <summary>Creation date of the last ticket automatically created based on this template.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_LastTicketCreationDate"/>
    public virtual DateTime? LastTicketCreationDate { get; set; }
    /// <summary>ID of the last ticket automatically created based on this template (FK).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_LastTicketId"/>
    public virtual int? LastTicketId { get; set; }
    /// <summary>Monthly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Monthly"/>
    public virtual bool Monthly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyAfterClosing"/>
    public virtual int? MonthlyAfterClosing { get; set; }
    /// <summary>Which day in the month.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInMonth"/>
    public virtual int? MonthlyDayInMonth { get; set; }
    /// <summary>Every X month.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInMonthEveryXMonths"/>
    public virtual int? MonthlyDayInMonthEveryXMonths { get; set; }
    /// <summary>Which weekday (1 - Monday, â¦, 8 - day, 9 - weekday).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInWeek"/>
    public virtual int? MonthlyDayInWeek { get; set; }
    /// <summary>Every X month.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInWeekEveryXMonths"/>
    public virtual int? MonthlyDayInWeekEveryXMonths { get; set; }
    /// <summary>Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyEveryXDayInWeek"/>
    public virtual int? MonthlyEveryXDayInWeek { get; set; }
    /// <summary>Template name (must be unique).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Next deadline for the planned ticket - only date (you cannot work with time).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_NextDate"/>
    public virtual DateTime? NextDate { get; set; }
    /// <summary>Planning (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Planning"/>
    public virtual bool Planning { get; set; }
    /// <summary>Link to user that deleted the template. The template is not deleted for NULL.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_RemovedByPersonId"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date on which the template was deleted. The template is not deleted for NULL.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_RemovedDate"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_SolverGroupId"/>
    public virtual int? SolverGroupId { get; set; }
    /// <summary>Solver ID (FK).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_SolverId"/>
    public virtual int? SolverId { get; set; }
    /// <summary>Beginning of repetition - only date (time is ignored).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_StartDate"/>
    public virtual DateTime? StartDate { get; set; }
    /// <summary>Number of created tickets based on this template in the current planning.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_TicketCreatedCount"/>
    public virtual int TicketCreatedCount { get; set; }
    /// <summary>Requester ID (FK).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_UserId"/>
    public virtual int? UserId { get; set; }
    /// <summary>Weekly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Weekly"/>
    public virtual bool Weekly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyAfterClosing"/>
    public virtual int? WeeklyAfterClosing { get; set; }
    /// <summary>Repetition period in weeks.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyEveryXDays"/>
    public virtual int? WeeklyEveryXDays { get; set; }
    /// <summary>On Fridays.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyFriday"/>
    public virtual bool WeeklyFriday { get; set; }
    /// <summary>On Mondays.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyMonday"/>
    public virtual bool WeeklyMonday { get; set; }
    /// <summary>On Saturdays.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklySaturday"/>
    public virtual bool WeeklySaturday { get; set; }
    /// <summary>On Sundays.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklySunday"/>
    public virtual bool WeeklySunday { get; set; }
    /// <summary>On Thursdays.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyThursday"/>
    public virtual bool WeeklyThursday { get; set; }
    /// <summary>On Tuesdays.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyTuesday"/>
    public virtual bool WeeklyTuesday { get; set; }
    /// <summary>On Wednesdays.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyWednesday"/>
    public virtual bool WeeklyWednesday { get; set; }
    /// <summary>Yearly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Yearly"/>
    public virtual bool Yearly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyAfterClosing"/>
    public virtual int? YearlyAfterClosing { get; set; }
    /// <summary>Which day in the month.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInMonth"/>
    public virtual int? YearlyDayInMonth { get; set; }
    /// <summary>Which month (1 - January, â¦).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInMonthOnMonth"/>
    public virtual int? YearlyDayInMonthOnMonth { get; set; }
    /// <summary>Which weekday (1 - Monday, â¦).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInWeek"/>
    public virtual int? YearlyDayInWeek { get; set; }
    /// <summary>Which month (1 - January, â¦).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInWeekOnMonth"/>
    public virtual int? YearlyDayInWeekOnMonth { get; set; }
    /// <summary>Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyEveryXDayInWeek"/>
    public virtual int? YearlyEveryXDayInWeek { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_id"/>
    [Key]
    public virtual int id { get; set; }
}
