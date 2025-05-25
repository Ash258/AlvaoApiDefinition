using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Executed operation which is logged.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogOperation.html"/>
[Table("dbo.RoleMembershipLogOperation")]
public class RoleMembershipLogOperation {
    /// <summary>Operation ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogOperation.html#Alvao_API_Common_Model_Database_RoleMembershipLogOperation_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Operation name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogOperation.html#Alvao_API_Common_Model_Database_RoleMembershipLogOperation_Name"/>
    public virtual string Name { get; set; }
}
