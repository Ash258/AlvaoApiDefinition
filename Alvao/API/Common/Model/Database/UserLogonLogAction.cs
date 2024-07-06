using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Executed action which is logged.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_UserLogonLogAction.htm"/>
[TableAttribute("dbo.UserLogonLogAction")]
public class UserLogonLogAction
{
    /// <summary>Action ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Action name.</summary>
    public virtual string Name { get; set; }

    public UserLogonLogAction() { }
}
