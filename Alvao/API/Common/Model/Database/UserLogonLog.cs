using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging users in/out to/from Asset Management Console.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_UserLogonLog.htm"/>
[TableAttribute("dbo.UserLogonLog")]
public class UserLogonLog {
    /// <summary>Kind of action from UserLogonLogAction.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLog_ActionId.htm"/>
    public virtual int ActionId { get; set; }
    /// <summary>Application to which the user has logged in.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLog_ApplicationId.htm"/>
    public virtual int ApplicationId { get; set; }
    /// <summary>Computer name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLog_Computer.htm"/>
    public virtual string Computer { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLog_Id.htm"/>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Identifier of whether or not the user was entitled to change the object security.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLog_IsAdmin.htm"/>
    public virtual bool IsAdmin { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLog_Person.htm"/>
    public virtual string Person { get; set; }
    /// <summary>The username of the logged-in user.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLog_PersonLogin.htm"/>
    public virtual string PersonLogin { get; set; }
    /// <summary>Date and time of logon/logout.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLog_TimeStamp.htm"/>
    public virtual DateTime TimeStamp { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_UserLogonLog__ctor.htm"/>
    public UserLogonLog() { }
}
