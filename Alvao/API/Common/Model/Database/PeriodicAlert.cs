using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Periodic alerts not defined by an SQL query. Sent by email, periodically with the selected regularity.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html"/>
[Table("dbo.PeriodicAlert")]
public class PeriodicAlert {
    /// <summary>If the CSV attachment is be attached to the notification. 1 = enabled, 0 = disabled</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_AttachCSV"/>
    /// <remarks>Column <c>AttachCSV</c>: bit, not null.</remarks>
    public virtual bool AttachCSV { get; set; }
    /// <summary>Description</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>Error message at the last SQL script run.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_ErrorMessage"/>
    /// <remarks>Column <c>ErrorMessage</c>: nvarchar(max), null.</remarks>
    public virtual string ErrorMessage { get; set; }
    /// <summary>If sending is enabled. 1 = enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_IsEnabled"/>
    /// <remarks>Column <c>IsEnabled</c>: bit, not null.</remarks>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Date and time of the last notice modification.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_LastModified"/>
    /// <remarks>Column <c>LastModified</c>: datetime, not null.</remarks>
    public virtual DateTime LastModified { get; set; }
    /// <summary>Date and time of last alert sent.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_LastSent"/>
    /// <remarks>Column <c>LastSent</c>: datetime, null.</remarks>
    public virtual DateTime? LastSent { get; set; }
    /// <summary>Alert name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Send period. A foreign key on PeriodicAlertPeriod.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_PeriodicAlertPeriodId"/>
    /// <remarks>
    /// Column <c>PeriodicAlertPeriodId</c>: tinyint, not null. References <see cref="PeriodicAlertPeriod"/>.
    /// </remarks>
    public virtual byte PeriodicAlertPeriodId { get; set; }
    /// <summary>If starting above the analytical database is enabled. 1 = enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_RunOverAnalyticalDatabase"/>
    /// <remarks>Column <c>RunOverAnalyticalDatabase</c>: bit, not null.</remarks>
    public virtual bool RunOverAnalyticalDatabase { get; set; }
    /// <summary>SQL query defining alerts.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_SqlQuery"/>
    /// <remarks>Column <c>SqlQuery</c>: nvarchar(max), null.</remarks>
    public virtual string SqlQuery { get; set; }
    /// <summary>
    /// Date and time from which the alert should be sent. At the same time, it is the starting point for calculating
    /// the date and time another will be sent according to the selected period.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_StartDate"/>
    /// <remarks>Column <c>StartDate</c>: datetime, not null.</remarks>
    public virtual DateTime StartDate { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
