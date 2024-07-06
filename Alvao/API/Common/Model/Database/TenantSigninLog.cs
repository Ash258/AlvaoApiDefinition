using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// User sign in log records
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TenantSigninLog.htm"/>
[TableAttribute("dbo.TenantSigninLog")]
public class TenantSigninLog
{
    /// <summary>Name of application that has generated log record.</summary>
    public virtual string Application { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Time stamp of created log record (UTC by default).</summary>
    public virtual DateTime LoggedDate { get; set; }
    /// <summary>Log level of the record</summary>
    public virtual int LogLevelId { get; set; }
    /// <summary>Log message</summary>
    public virtual string Message { get; set; }
    /// <summary>Additional detailed text parameters of the log record.</summary>
    public virtual string Parameters { get; set; }

    public TenantSigninLog() { }
}
