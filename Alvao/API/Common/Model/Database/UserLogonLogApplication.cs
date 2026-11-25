using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Application name.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogApplication.html"/>
[Table("dbo.UserLogonLogApplication")]
public class UserLogonLogApplication {
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogApplication.html#Alvao_API_Common_Model_Database_UserLogonLogApplication_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Application name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.UserLogonLogApplication.html#Alvao_API_Common_Model_Database_UserLogonLogApplication_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(50), not null.</remarks>
    public virtual string Name { get; set; }
}
