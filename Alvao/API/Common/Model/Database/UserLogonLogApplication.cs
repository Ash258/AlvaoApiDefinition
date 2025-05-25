using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Application name.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogApplication.html"/>
[Table("dbo.UserLogonLogApplication")]
public class UserLogonLogApplication {
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogApplication.html#Alvao_API_Common_Model_Database_UserLogonLogApplication_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Application name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogApplication.html#Alvao_API_Common_Model_Database_UserLogonLogApplication_Name"/>
    public virtual string Name { get; set; }
}
