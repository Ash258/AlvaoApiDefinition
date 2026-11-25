using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of ticket templates</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html"/>
[Table("dbo.TicketTemplate")]
public class TicketTemplate {
    /// <summary>Daily (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Daily"/>
    /// <remarks>Column <c>Daily</c>: bit, not null.</remarks>
    public virtual bool Daily { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_DailyAfterClosing"/>
    /// <remarks>Column <c>DailyAfterClosing</c>: int, null.</remarks>
    public virtual int? DailyAfterClosing { get; set; }
    /// <summary>On weekdays (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_DailyEveryWeekday"/>
    /// <remarks>Column <c>DailyEveryWeekday</c>: bit, not null.</remarks>
    public virtual bool DailyEveryWeekday { get; set; }
    /// <summary>Repetition period in days.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_DailyEveryXDays"/>
    /// <remarks>Column <c>DailyEveryXDays</c>: int, null.</remarks>
    public virtual int? DailyEveryXDays { get; set; }
    /// <summary>Description of template.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>Number of occurrences upon which planning is finished.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_EndAfter"/>
    /// <remarks>Column <c>EndAfter</c>: int, null.</remarks>
    public virtual int? EndAfter { get; set; }
    /// <summary>End of repetition - only the date of the last available creation (you cannot work with time).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_EndDate"/>
    /// <remarks>Column <c>EndDate</c>: datetime, null.</remarks>
    public virtual DateTime? EndDate { get; set; }
    /// <summary>ID of service in which the template is created.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int HdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <summary>Creation date of the last ticket automatically created based on this template.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_LastTicketCreationDate"/>
    /// <remarks>Column <c>LastTicketCreationDate</c>: datetime, null.</remarks>
    public virtual DateTime? LastTicketCreationDate { get; set; }
    /// <summary>ID of the last ticket automatically created based on this template (FK).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_LastTicketId"/>
    /// <remarks>Column <c>LastTicketId</c>: int, null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int? LastTicketId { get; set; }
    /// <summary>Monthly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Monthly"/>
    /// <remarks>Column <c>Monthly</c>: bit, not null.</remarks>
    public virtual bool Monthly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyAfterClosing"/>
    /// <remarks>Column <c>MonthlyAfterClosing</c>: int, null.</remarks>
    public virtual int? MonthlyAfterClosing { get; set; }
    /// <summary>Which day in the month.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInMonth"/>
    /// <remarks>Column <c>MonthlyDayInMonth</c>: int, null.</remarks>
    public virtual int? MonthlyDayInMonth { get; set; }
    /// <summary>Every X month.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInMonthEveryXMonths"/>
    /// <remarks>Column <c>MonthlyDayInMonthEveryXMonths</c>: int, null.</remarks>
    public virtual int? MonthlyDayInMonthEveryXMonths { get; set; }
    /// <summary>Which weekday (1 - Monday, â¦, 8 - day, 9 - weekday).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInWeek"/>
    /// <remarks>Column <c>MonthlyDayInWeek</c>: int, null.</remarks>
    public virtual int? MonthlyDayInWeek { get; set; }
    /// <summary>Every X month.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInWeekEveryXMonths"/>
    /// <remarks>Column <c>MonthlyDayInWeekEveryXMonths</c>: int, null.</remarks>
    public virtual int? MonthlyDayInWeekEveryXMonths { get; set; }
    /// <summary>Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_MonthlyEveryXDayInWeek"/>
    /// <remarks>Column <c>MonthlyEveryXDayInWeek</c>: int, null.</remarks>
    public virtual int? MonthlyEveryXDayInWeek { get; set; }
    /// <summary>Template name (must be unique).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Next deadline for the planned ticket - only date (you cannot work with time).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_NextDate"/>
    /// <remarks>Column <c>NextDate</c>: datetime, null.</remarks>
    public virtual DateTime? NextDate { get; set; }
    /// <summary>Planning (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Planning"/>
    /// <remarks>Column <c>Planning</c>: bit, not null.</remarks>
    public virtual bool Planning { get; set; }
    /// <summary>Link to user that deleted the template. The template is not deleted for NULL.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date on which the template was deleted. The template is not deleted for NULL.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_RemovedDate"/>
    /// <remarks>Column <c>RemovedDate</c>: datetime, null.</remarks>
    public virtual DateTime? RemovedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_SolverGroupId"/>
    /// <remarks>Column <c>SolverGroupId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? SolverGroupId { get; set; }
    /// <summary>Solver ID (FK).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_SolverId"/>
    /// <remarks>Column <c>SolverId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? SolverId { get; set; }
    /// <summary>Beginning of repetition - only date (time is ignored).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_StartDate"/>
    /// <remarks>Column <c>StartDate</c>: datetime, null.</remarks>
    public virtual DateTime? StartDate { get; set; }
    /// <summary>Number of created tickets based on this template in the current planning.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_TicketCreatedCount"/>
    /// <remarks>Column <c>TicketCreatedCount</c>: int, not null.</remarks>
    public virtual int TicketCreatedCount { get; set; }
    /// <summary>Requester ID (FK).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_UserId"/>
    /// <remarks>Column <c>UserId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? UserId { get; set; }
    /// <summary>Weekly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Weekly"/>
    /// <remarks>Column <c>Weekly</c>: bit, not null.</remarks>
    public virtual bool Weekly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyAfterClosing"/>
    /// <remarks>Column <c>WeeklyAfterClosing</c>: int, null.</remarks>
    public virtual int? WeeklyAfterClosing { get; set; }
    /// <summary>Repetition period in weeks.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyEveryXDays"/>
    /// <remarks>Column <c>WeeklyEveryXDays</c>: int, null.</remarks>
    public virtual int? WeeklyEveryXDays { get; set; }
    /// <summary>On Fridays.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyFriday"/>
    /// <remarks>Column <c>WeeklyFriday</c>: bit, not null.</remarks>
    public virtual bool WeeklyFriday { get; set; }
    /// <summary>On Mondays.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyMonday"/>
    /// <remarks>Column <c>WeeklyMonday</c>: bit, not null.</remarks>
    public virtual bool WeeklyMonday { get; set; }
    /// <summary>On Saturdays.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklySaturday"/>
    /// <remarks>Column <c>WeeklySaturday</c>: bit, not null.</remarks>
    public virtual bool WeeklySaturday { get; set; }
    /// <summary>On Sundays.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklySunday"/>
    /// <remarks>Column <c>WeeklySunday</c>: bit, not null.</remarks>
    public virtual bool WeeklySunday { get; set; }
    /// <summary>On Thursdays.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyThursday"/>
    /// <remarks>Column <c>WeeklyThursday</c>: bit, not null.</remarks>
    public virtual bool WeeklyThursday { get; set; }
    /// <summary>On Tuesdays.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyTuesday"/>
    /// <remarks>Column <c>WeeklyTuesday</c>: bit, not null.</remarks>
    public virtual bool WeeklyTuesday { get; set; }
    /// <summary>On Wednesdays.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_WeeklyWednesday"/>
    /// <remarks>Column <c>WeeklyWednesday</c>: bit, not null.</remarks>
    public virtual bool WeeklyWednesday { get; set; }
    /// <summary>Yearly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_Yearly"/>
    /// <remarks>Column <c>Yearly</c>: bit, not null.</remarks>
    public virtual bool Yearly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyAfterClosing"/>
    /// <remarks>Column <c>YearlyAfterClosing</c>: int, null.</remarks>
    public virtual int? YearlyAfterClosing { get; set; }
    /// <summary>Which day in the month.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInMonth"/>
    /// <remarks>Column <c>YearlyDayInMonth</c>: int, null.</remarks>
    public virtual int? YearlyDayInMonth { get; set; }
    /// <summary>Which month (1 - January, â¦).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInMonthOnMonth"/>
    /// <remarks>Column <c>YearlyDayInMonthOnMonth</c>: int, null.</remarks>
    public virtual int? YearlyDayInMonthOnMonth { get; set; }
    /// <summary>Which weekday (1 - Monday, â¦).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInWeek"/>
    /// <remarks>Column <c>YearlyDayInWeek</c>: int, null.</remarks>
    public virtual int? YearlyDayInWeek { get; set; }
    /// <summary>Which month (1 - January, â¦).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInWeekOnMonth"/>
    /// <remarks>Column <c>YearlyDayInWeekOnMonth</c>: int, null.</remarks>
    public virtual int? YearlyDayInWeekOnMonth { get; set; }
    /// <summary>Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_YearlyEveryXDayInWeek"/>
    /// <remarks>Column <c>YearlyEveryXDayInWeek</c>: int, null.</remarks>
    public virtual int? YearlyEveryXDayInWeek { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplate.html#Alvao_API_Common_Model_Database_TicketTemplate_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
