using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kind of membership in the group.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogMemberType.html"/>
[Table("dbo.RoleMembershipLogMemberType")]
public class RoleMembershipLogMemberType {
    /// <summary>Membership kind ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogMemberType.html#Alvao_API_Common_Model_Database_RoleMembershipLogMemberType_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Membership kind name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogMemberType.html#Alvao_API_Common_Model_Database_RoleMembershipLogMemberType_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(50), not null.</remarks>
    public virtual string Name { get; set; }
}
