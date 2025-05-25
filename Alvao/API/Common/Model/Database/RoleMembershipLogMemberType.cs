using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kind of membership in the group.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogMemberType.html"/>
[Table("dbo.RoleMembershipLogMemberType")]
public class RoleMembershipLogMemberType {
    /// <summary>Membership kind ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogMemberType.html#Alvao_API_Common_Model_Database_RoleMembershipLogMemberType_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Membership kind name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLogMemberType.html#Alvao_API_Common_Model_Database_RoleMembershipLogMemberType_Name"/>
    public virtual string Name { get; set; }
}
