using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of ticket templates
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTemplate.htm"/>
[TableAttribute("dbo.TicketTemplate")]
public class TicketTemplate
{
    /// <summary>Daily (0 - off, 1 - on).</summary>
    public virtual bool Daily { get; set; }
    /// <summary>Upon closing the previous.</summary>
    public virtual int? DailyAfterClosing { get; set; }
    /// <summary>On weekdays (0 - off, 1 - on).</summary>
    public virtual bool DailyEveryWeekday { get; set; }
    /// <summary>Repetition period in days.</summary>
    public virtual int? DailyEveryXDays { get; set; }
    /// <summary>Description of template.</summary>
    public virtual string Description { get; set; }
    /// <summary>Number of occurrences upon which planning is finished.</summary>
    public virtual int? EndAfter { get; set; }
    /// <summary>End of repetition - only the date of the last available creation (you cannot work with time).</summary>
    public virtual DateTime? EndDate { get; set; }
    /// <summary>ID of service in which the template is created.</summary>
    public virtual int HdSectionId { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Creation date of the last ticket automatically created based on this template.</summary>
    public virtual DateTime? LastTicketCreationDate { get; set; }
    /// <summary>ID of the last ticket automatically created based on this template (FK).</summary>
    public virtual int? LastTicketId { get; set; }
    /// <summary>Monthly (0 - off, 1 - on).</summary>
    public virtual bool Monthly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    public virtual int? MonthlyAfterClosing { get; set; }
    /// <summary>Which day in the month.</summary>
    public virtual int? MonthlyDayInMonth { get; set; }
    /// <summary>Every X month.</summary>
    public virtual int? MonthlyDayInMonthEveryXMonths { get; set; }
    /// <summary>Which weekday (1 - Monday, …, 8 - day, 9 - weekday).</summary>
    public virtual int? MonthlyDayInWeek { get; set; }
    /// <summary>Every X month.</summary>
    public virtual int? MonthlyDayInWeekEveryXMonths { get; set; }
    /// <summary>Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last).</summary>
    public virtual int? MonthlyEveryXDayInWeek { get; set; }
    /// <summary>Template name (must be unique).</summary>
    public virtual string Name { get; set; }
    /// <summary>Next deadline for the planned ticket - only date (you cannot work with time).</summary>
    public virtual DateTime? NextDate { get; set; }
    /// <summary>Planning (0 - off, 1 - on).</summary>
    public virtual bool Planning { get; set; }
    /// <summary>Link to user that deleted the template. The template is not deleted for NULL.</summary>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date on which the template was deleted. The template is not deleted for NULL.</summary>
    public virtual DateTime? RemovedDate { get; set; }
    public virtual int? SolverGroupId { get; set; }
    /// <summary>Solver ID (FK).</summary>
    public virtual int? SolverId { get; set; }
    /// <summary>Beginning of repetition - only date (time is ignored).</summary>
    public virtual DateTime? StartDate { get; set; }
    /// <summary>Number of created tickets based on this template in the current planning.</summary>
    public virtual int TicketCreatedCount { get; set; }
    /// <summary>Requester ID (FK).</summary>
    public virtual int? UserId { get; set; }
    /// <summary>Weekly (0 - off, 1 - on).</summary>
    public virtual bool Weekly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    public virtual int? WeeklyAfterClosing { get; set; }
    /// <summary>Repetition period in weeks.</summary>
    public virtual int? WeeklyEveryXDays { get; set; }
    /// <summary>On Fridays.</summary>
    public virtual bool WeeklyFriday { get; set; }
    /// <summary>On Mondays.</summary>
    public virtual bool WeeklyMonday { get; set; }
    /// <summary>On Saturdays.</summary>
    public virtual bool WeeklySaturday { get; set; }
    /// <summary>On Sundays.</summary>
    public virtual bool WeeklySunday { get; set; }
    /// <summary>On Thursdays.</summary>
    public virtual bool WeeklyThursday { get; set; }
    /// <summary>On Tuesdays.</summary>
    public virtual bool WeeklyTuesday { get; set; }
    /// <summary>On Wednesdays.</summary>
    public virtual bool WeeklyWednesday { get; set; }
    /// <summary>Yearly (0 - off, 1 - on).</summary>
    public virtual bool Yearly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    public virtual int? YearlyAfterClosing { get; set; }
    /// <summary>Which day in the month.</summary>
    public virtual int? YearlyDayInMonth { get; set; }
    /// <summary>Which month (1 - January, …).</summary>
    public virtual int? YearlyDayInMonthOnMonth { get; set; }
    /// <summary>Which weekday (1 - Monday, …).</summary>
    public virtual int? YearlyDayInWeek { get; set; }
    /// <summary>Which month (1 - January, …).</summary>
    public virtual int? YearlyDayInWeekOnMonth { get; set; }
    /// <summary>Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last).</summary>
    public virtual int? YearlyEveryXDayInWeek { get; set; }

    public TicketTemplate() { }
}
