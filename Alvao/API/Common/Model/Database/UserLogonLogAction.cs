using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Executed action which is logged.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_UserLogonLogAction.htm"/>
[TableAttribute("dbo.UserLogonLogAction")]
public class UserLogonLogAction
{
    /// <summary>Action ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLogAction_Id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Action name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_UserLogonLogAction_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_UserLogonLogAction__ctor.htm"/>
    public UserLogonLogAction() { }
}
