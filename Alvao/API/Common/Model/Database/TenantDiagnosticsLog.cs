using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Tenant diagnostics log records</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TenantDiagnosticsLog.htm"/>
[TableAttribute("dbo.TenantDiagnosticsLog")]
public class TenantDiagnosticsLog
{
    /// <summary>Name of application that generated the log record.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Application.htm"/>
    public virtual string Application { get; set; }
    /// <summary>Context of the logged event (e.g., a source code class name, method name, etc.)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Callsite.htm"/>
    public virtual string Callsite { get; set; }
    /// <summary>Occurred exception information</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Exception.htm"/>
    public virtual string Exception { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantDiagnosticsLog_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Time stamp of created log record (UTC by default).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantDiagnosticsLog_LoggedDate.htm"/>
    public virtual DateTime LoggedDate { get; set; }
    /// <summary>Log level of the record</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantDiagnosticsLog_LogLevelId.htm"/>
    public virtual int LogLevelId { get; set; }
    /// <summary>Log message</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Message.htm"/>
    public virtual string Message { get; set; }
    /// <summary>Additional detailed text parameters of the log record.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantDiagnosticsLog_Parameters.htm"/>
    public virtual string Parameters { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TenantDiagnosticsLog__ctor.htm"/>
    public TenantDiagnosticsLog() { }
}
