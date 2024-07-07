using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of ticket templates</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTemplate.htm"/>
[TableAttribute("dbo.TicketTemplate")]
public class TicketTemplate
{
    /// <summary>Daily (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_Daily.htm"/>
    public virtual bool Daily { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_DailyAfterClosing.htm"/>
    public virtual int? DailyAfterClosing { get; set; }
    /// <summary>On weekdays (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_DailyEveryWeekday.htm"/>
    public virtual bool DailyEveryWeekday { get; set; }
    /// <summary>Repetition period in days.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_DailyEveryXDays.htm"/>
    public virtual int? DailyEveryXDays { get; set; }
    /// <summary>Description of template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_Description.htm"/>
    public virtual string Description { get; set; }
    /// <summary>Number of occurrences upon which planning is finished.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_EndAfter.htm"/>
    public virtual int? EndAfter { get; set; }
    /// <summary>End of repetition - only the date of the last available creation (you cannot work with time).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_EndDate.htm"/>
    public virtual DateTime? EndDate { get; set; }
    /// <summary>ID of service in which the template is created.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_HdSectionId.htm"/>
    public virtual int HdSectionId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Creation date of the last ticket automatically created based on this template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_LastTicketCreationDate.htm"/>
    public virtual DateTime? LastTicketCreationDate { get; set; }
    /// <summary>ID of the last ticket automatically created based on this template (FK).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_LastTicketId.htm"/>
    public virtual int? LastTicketId { get; set; }
    /// <summary>Monthly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_Monthly.htm"/>
    public virtual bool Monthly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_MonthlyAfterClosing.htm"/>
    public virtual int? MonthlyAfterClosing { get; set; }
    /// <summary>Which day in the month.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInMonth.htm"/>
    public virtual int? MonthlyDayInMonth { get; set; }
    /// <summary>Every X month.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInMonthEveryXMonths.htm"/>
    public virtual int? MonthlyDayInMonthEveryXMonths { get; set; }
    /// <summary>Which weekday (1 - Monday, …, 8 - day, 9 - weekday).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInWeek.htm"/>
    public virtual int? MonthlyDayInWeek { get; set; }
    /// <summary>Every X month.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_MonthlyDayInWeekEveryXMonths.htm"/>
    public virtual int? MonthlyDayInWeekEveryXMonths { get; set; }
    /// <summary>Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_MonthlyEveryXDayInWeek.htm"/>
    public virtual int? MonthlyEveryXDayInWeek { get; set; }
    /// <summary>Template name (must be unique).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>Next deadline for the planned ticket - only date (you cannot work with time).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_NextDate.htm"/>
    public virtual DateTime? NextDate { get; set; }
    /// <summary>Planning (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_Planning.htm"/>
    public virtual bool Planning { get; set; }
    /// <summary>Link to user that deleted the template. The template is not deleted for NULL.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_RemovedByPersonId.htm"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date on which the template was deleted. The template is not deleted for NULL.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_RemovedDate.htm"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_SolverGroupId.htm"/>
    public virtual int? SolverGroupId { get; set; }
    /// <summary>Solver ID (FK).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_SolverId.htm"/>
    public virtual int? SolverId { get; set; }
    /// <summary>Beginning of repetition - only date (time is ignored).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_StartDate.htm"/>
    public virtual DateTime? StartDate { get; set; }
    /// <summary>Number of created tickets based on this template in the current planning.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_TicketCreatedCount.htm"/>
    public virtual int TicketCreatedCount { get; set; }
    /// <summary>Requester ID (FK).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_UserId.htm"/>
    public virtual int? UserId { get; set; }
    /// <summary>Weekly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_Weekly.htm"/>
    public virtual bool Weekly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklyAfterClosing.htm"/>
    public virtual int? WeeklyAfterClosing { get; set; }
    /// <summary>Repetition period in weeks.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklyEveryXDays.htm"/>
    public virtual int? WeeklyEveryXDays { get; set; }
    /// <summary>On Fridays.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklyFriday.htm"/>
    public virtual bool WeeklyFriday { get; set; }
    /// <summary>On Mondays.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklyMonday.htm"/>
    public virtual bool WeeklyMonday { get; set; }
    /// <summary>On Saturdays.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklySaturday.htm"/>
    public virtual bool WeeklySaturday { get; set; }
    /// <summary>On Sundays.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklySunday.htm"/>
    public virtual bool WeeklySunday { get; set; }
    /// <summary>On Thursdays.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklyThursday.htm"/>
    public virtual bool WeeklyThursday { get; set; }
    /// <summary>On Tuesdays.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklyTuesday.htm"/>
    public virtual bool WeeklyTuesday { get; set; }
    /// <summary>On Wednesdays.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_WeeklyWednesday.htm"/>
    public virtual bool WeeklyWednesday { get; set; }
    /// <summary>Yearly (0 - off, 1 - on).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_Yearly.htm"/>
    public virtual bool Yearly { get; set; }
    /// <summary>Upon closing the previous.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_YearlyAfterClosing.htm"/>
    public virtual int? YearlyAfterClosing { get; set; }
    /// <summary>Which day in the month.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInMonth.htm"/>
    public virtual int? YearlyDayInMonth { get; set; }
    /// <summary>Which month (1 - January, …).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInMonthOnMonth.htm"/>
    public virtual int? YearlyDayInMonthOnMonth { get; set; }
    /// <summary>Which weekday (1 - Monday, …).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInWeek.htm"/>
    public virtual int? YearlyDayInWeek { get; set; }
    /// <summary>Which month (1 - January, …).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_YearlyDayInWeekOnMonth.htm"/>
    public virtual int? YearlyDayInWeekOnMonth { get; set; }
    /// <summary>Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTemplate_YearlyEveryXDayInWeek.htm"/>
    public virtual int? YearlyEveryXDayInWeek { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketTemplate__ctor.htm"/>
    public TicketTemplate() { }
}
