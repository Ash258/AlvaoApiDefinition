using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Executed action which is logged.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogAction.html"/>
[Table("dbo.UserLogonLogAction")]
public class UserLogonLogAction {
    /// <summary>Action ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogAction.html#Alvao_API_Common_Model_Database_UserLogonLogAction_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Action name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogAction.html#Alvao_API_Common_Model_Database_UserLogonLogAction_Name"/>
    public virtual string Name { get; set; }
}
