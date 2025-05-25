using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>User sign in log records</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html"/>
[Table("dbo.TenantSigninLog")]
public class TenantSigninLog {
    /// <summary>Name of application that has generated log record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_Application"/>
    public virtual string Application { get; set; }
    /// <summary>Log level of the record</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_LogLevelId"/>
    public virtual int LogLevelId { get; set; }
    /// <summary>Time stamp of created log record (UTC by default).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_LoggedDate"/>
    [ExplicitKey]
    public virtual DateTime LoggedDate { get; set; }
    /// <summary>Log message</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_Message"/>
    public virtual string Message { get; set; }
    /// <summary>Additional detailed text parameters of the log record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_Parameters"/>
    public virtual string Parameters { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TenantSigninLog.html#Alvao_API_Common_Model_Database_TenantSigninLog_id"/>
    public virtual int id { get; set; }
}
