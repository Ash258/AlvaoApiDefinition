using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging users in/out to/from Asset Management Console.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html"/>
[Table("dbo.UserLogonLog")]
public class UserLogonLog {
    /// <summary>Kind of action from UserLogonLogAction.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_ActionId"/>
    public virtual int ActionId { get; set; }
    /// <summary>Application to which the user has logged in.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_ApplicationId"/>
    public virtual int ApplicationId { get; set; }
    /// <summary>Computer name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_Computer"/>
    public virtual string Computer { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Identifier of whether or not the user was entitled to change the object security.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_IsAdmin"/>
    public virtual bool IsAdmin { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_Person"/>
    public virtual string Person { get; set; }
    /// <summary>The username of the logged-in user.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_PersonLogin"/>
    public virtual string PersonLogin { get; set; }
    /// <summary>Date and time of logon/logout.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_TimeStamp"/>
    public virtual DateTime TimeStamp { get; set; }
}
