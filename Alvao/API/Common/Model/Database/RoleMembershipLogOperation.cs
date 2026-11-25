using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Executed operation which is logged.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogOperation.html"/>
[Table("dbo.RoleMembershipLogOperation")]
public class RoleMembershipLogOperation {
    /// <summary>Operation ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogOperation.html#Alvao_API_Common_Model_Database_RoleMembershipLogOperation_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Operation name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogOperation.html#Alvao_API_Common_Model_Database_RoleMembershipLogOperation_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(50), not null.</remarks>
    public virtual string Name { get; set; }
}
