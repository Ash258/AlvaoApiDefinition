using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Periodic alerts not defined by an SQL query. Sent by e-mail, periodically with the selected regularity.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PeriodicAlert.htm"/>
[TableAttribute("dbo.PeriodicAlert")]
public class PeriodicAlert
{
    /// <summary>If the CSV attachment is be attached to the notification. 1 = enabled, 0 = disabled</summary>
    public virtual bool AttachCSV { get; set; }
    /// <summary>Description</summary>
    public virtual string Description { get; set; }
    /// <summary>Error message at the last SQL script run.</summary>
    public virtual string ErrorMessage { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>If sending is enabled. 1 = enabled, 0 = disabled.</summary>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Date and time of the last notice modification.</summary>
    public virtual DateTime LastModified { get; set; }
    /// <summary>Date and time of last alert sent.</summary>
    public virtual DateTime? LastSent { get; set; }
    /// <summary>Alert name</summary>
    public virtual string Name { get; set; }
    /// <summary>Send period. A foreign key on PeriodicAlertPeriod.</summary>
    public virtual byte PeriodicAlertPeriodId { get; set; }
    /// <summary>If starting above the analytical database is enabled. 1 = enabled, 0 = disabled.</summary>
    public virtual bool RunOverAnalyticalDatabase { get; set; }
    /// <summary>SQL query defining alerts.</summary>
    public virtual string SqlQuery { get; set; }
    /// <summary>Date and time from which the alert should be sent. At the same time, it is the starting point for calculating the date and time another will be sent according to the selected period.</summary>
    public virtual DateTime StartDate { get; set; }

    public PeriodicAlert() { }
}
