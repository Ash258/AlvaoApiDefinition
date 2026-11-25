using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Tenant diagnostics log records</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html"/>
[Table("dbo.TenantDiagnosticsLog")]
public class TenantDiagnosticsLog {
    /// <summary>Name of application that generated the log record.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Application"/>
    /// <remarks>Column <c>Application</c>: nvarchar(250), null.</remarks>
    public virtual string Application { get; set; }
    /// <summary>Context of the logged event (e.g., a source code class name, method name, etc.)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Callsite"/>
    /// <remarks>Column <c>Callsite</c>: nvarchar(max), null.</remarks>
    public virtual string Callsite { get; set; }
    /// <summary>Occurred exception information</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Exception"/>
    /// <remarks>Column <c>Exception</c>: nvarchar(max), null.</remarks>
    public virtual string Exception { get; set; }
    /// <summary>Log level of the record</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_LogLevelId"/>
    /// <remarks>Column <c>LogLevelId</c>: int, not null. References <see cref="LogLevel"/>.</remarks>
    public virtual int LogLevelId { get; set; }
    /// <summary>Time stamp of created log record (UTC by default).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_LoggedDate"/>
    /// <remarks>Column <c>LoggedDate</c>: datetime, not null.</remarks>
    [ExplicitKey]
    public virtual DateTime LoggedDate { get; set; }
    /// <summary>Log message</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Message"/>
    /// <remarks>Column <c>Message</c>: nvarchar(max), null.</remarks>
    public virtual string Message { get; set; }
    /// <summary>Additional detailed text parameters of the log record.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Parameters"/>
    /// <remarks>Column <c>Parameters</c>: nvarchar(max), null.</remarks>
    public virtual string Parameters { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    public virtual int id { get; set; }
}
