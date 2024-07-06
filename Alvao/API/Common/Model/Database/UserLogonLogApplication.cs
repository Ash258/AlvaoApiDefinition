using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Application name.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_UserLogonLogApplication.htm"/>
[TableAttribute("dbo.UserLogonLogApplication")]
public class UserLogonLogApplication
{
    /// <summary>Application ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Application name.</summary>
    public virtual string Name { get; set; }

    public UserLogonLogApplication() { }
}
