using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging users in/out to/from Asset Management Console.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html"/>
[Table("dbo.UserLogonLog")]
public class UserLogonLog {
    /// <summary>Kind of action from UserLogonLogAction.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_ActionId"/>
    /// <remarks>Column <c>ActionId</c>: int, not null. References <see cref="UserLogonLogAction"/>.</remarks>
    public virtual int ActionId { get; set; }
    /// <summary>Application to which the user has logged in.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_ApplicationId"/>
    /// <remarks>Column <c>ApplicationId</c>: int, not null. References <see cref="UserLogonLogApplication"/>.</remarks>
    public virtual int ApplicationId { get; set; }
    /// <summary>Computer name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_Computer"/>
    /// <remarks>Column <c>Computer</c>: nvarchar(255), null.</remarks>
    public virtual string Computer { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Identifier of whether or not the user was entitled to change the object security.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_IsAdmin"/>
    /// <remarks>Column <c>IsAdmin</c>: bit, not null.</remarks>
    public virtual bool IsAdmin { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_Person"/>
    /// <remarks>Column <c>Person</c>: nvarchar(255), null.</remarks>
    public virtual string Person { get; set; }
    /// <summary>The username of the logged-in user.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_PersonLogin"/>
    /// <remarks>Column <c>PersonLogin</c>: nvarchar(255), not null.</remarks>
    public virtual string PersonLogin { get; set; }
    /// <summary>Date and time of logon/logout.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLog.html#Alvao_API_Common_Model_Database_UserLogonLog_TimeStamp"/>
    /// <remarks>Column <c>TimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime TimeStamp { get; set; }
}
