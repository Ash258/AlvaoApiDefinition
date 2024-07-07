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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantSigninLog_Application.htm"/>
    public virtual string Application { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantSigninLog_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Time stamp of created log record (UTC by default).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantSigninLog_LoggedDate.htm"/>
    public virtual DateTime LoggedDate { get; set; }
    /// <summary>Log level of the record</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantSigninLog_LogLevelId.htm"/>
    public virtual int LogLevelId { get; set; }
    /// <summary>Log message</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantSigninLog_Message.htm"/>
    public virtual string Message { get; set; }
    /// <summary>Additional detailed text parameters of the log record.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TenantSigninLog_Parameters.htm"/>
    public virtual string Parameters { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TenantSigninLog__ctor.htm"/>
    public TenantSigninLog() { }
}
