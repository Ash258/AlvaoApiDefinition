using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Tenant diagnostics log records</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html"/>
[Table("dbo.TenantDiagnosticsLog")]
public class TenantDiagnosticsLog {
    /// <summary>Name of application that generated the log record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Application"/>
    public virtual string Application { get; set; }
    /// <summary>Context of the logged event (e.g., a source code class name, method name, etc.)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Callsite"/>
    public virtual string Callsite { get; set; }
    /// <summary>Occurred exception information</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Exception"/>
    public virtual string Exception { get; set; }
    /// <summary>Log level of the record</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_LogLevelId"/>
    public virtual int LogLevelId { get; set; }
    /// <summary>Time stamp of created log record (UTC by default).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_LoggedDate"/>
    [ExplicitKey]
    public virtual DateTime LoggedDate { get; set; }
    /// <summary>Log message</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Message"/>
    public virtual string Message { get; set; }
    /// <summary>Additional detailed text parameters of the log record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Parameters"/>
    public virtual string Parameters { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantDiagnosticsLog.html#Alvao_API_Common_Model_Database_TenantDiagnosticsLog_id"/>
    public virtual int id { get; set; }
}
