using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>User sign in log records</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html"/>
[Table("dbo.TenantSigninLog")]
public class TenantSigninLog {
    /// <summary>Name of application that has generated log record.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_Application"/>
    /// <remarks>Column <c>Application</c>: nvarchar(250), null.</remarks>
    public virtual string Application { get; set; }
    /// <summary>Log level of the record</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_LogLevelId"/>
    /// <remarks>Column <c>LogLevelId</c>: int, not null. References <see cref="LogLevel"/>.</remarks>
    public virtual int LogLevelId { get; set; }
    /// <summary>Time stamp of created log record (UTC by default).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_LoggedDate"/>
    /// <remarks>Column <c>LoggedDate</c>: datetime, not null.</remarks>
    [ExplicitKey]
    public virtual DateTime LoggedDate { get; set; }
    /// <summary>Log message</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_Message"/>
    /// <remarks>Column <c>Message</c>: nvarchar(max), null.</remarks>
    public virtual string Message { get; set; }
    /// <summary>Additional detailed text parameters of the log record.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_Parameters"/>
    /// <remarks>Column <c>Parameters</c>: nvarchar(max), null.</remarks>
    public virtual string Parameters { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    public virtual int id { get; set; }
}
