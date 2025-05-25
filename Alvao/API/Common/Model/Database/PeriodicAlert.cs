using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Periodic alerts not defined by an SQL query. Sent by e-mail, periodically with the selected regularity.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html"/>
[Table("dbo.PeriodicAlert")]
public class PeriodicAlert {
    /// <summary>If the CSV attachment is be attached to the notification. 1 = enabled, 0 = disabled</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_AttachCSV"/>
    public virtual bool AttachCSV { get; set; }
    /// <summary>Description</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Error message at the last SQL script run.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_ErrorMessage"/>
    public virtual string ErrorMessage { get; set; }
    /// <summary>If sending is enabled. 1 = enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_IsEnabled"/>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Date and time of the last notice modification.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_LastModified"/>
    public virtual DateTime LastModified { get; set; }
    /// <summary>Date and time of last alert sent.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_LastSent"/>
    public virtual DateTime? LastSent { get; set; }
    /// <summary>Alert name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Send period. A foreign key on PeriodicAlertPeriod.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_PeriodicAlertPeriodId"/>
    public virtual byte PeriodicAlertPeriodId { get; set; }
    /// <summary>If starting above the analytical database is enabled. 1 = enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_RunOverAnalyticalDatabase"/>
    public virtual bool RunOverAnalyticalDatabase { get; set; }
    /// <summary>SQL query defining alerts.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_SqlQuery"/>
    public virtual string SqlQuery { get; set; }
    /// <summary>Date and time from which the alert should be sent. At the same time, it is the starting point for calculating the date and time another will be sent according to the selected period.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_StartDate"/>
    public virtual DateTime StartDate { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PeriodicAlert.html#Alvao_API_Common_Model_Database_PeriodicAlert_id"/>
    [Key]
    public virtual int id { get; set; }
}
