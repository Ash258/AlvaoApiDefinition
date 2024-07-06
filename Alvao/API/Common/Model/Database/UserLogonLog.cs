using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Logging users in/out to/from Asset Management Console.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_UserLogonLog.htm"/>
[TableAttribute("dbo.UserLogonLog")]
public class UserLogonLog
{
    /// <summary>Kind of action from UserLogonLogAction.</summary>
    public virtual int ActionId { get; set; }
    /// <summary>Application to which the user has logged in.</summary>
    public virtual int ApplicationId { get; set; }
    /// <summary>Computer name.</summary>
    public virtual string Computer { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Identifier of whether or not the user was entitled to change the object security.</summary>
    public virtual bool IsAdmin { get; set; }
    /// <summary>Logged-in user name.</summary>
    public virtual string Person { get; set; }
    /// <summary>The username of the logged-in user.</summary>
    public virtual string PersonLogin { get; set; }
    /// <summary>Date and time of logon/logout.</summary>
    public virtual DateTime TimeStamp { get; set; }

    public UserLogonLog() { }
}
