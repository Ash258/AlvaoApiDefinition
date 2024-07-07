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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLogApplication_Id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Application name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLogApplication_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_UserLogonLogApplication__ctor.htm"/>
    public UserLogonLogApplication() { }
}
