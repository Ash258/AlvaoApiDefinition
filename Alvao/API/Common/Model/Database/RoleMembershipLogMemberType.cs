using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kind of membership in the group.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RoleMembershipLogMemberType.htm"/>
[TableAttribute("dbo.RoleMembershipLogMemberType")]
public class RoleMembershipLogMemberType {
    /// <summary>Membership kind ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLogMemberType_Id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Membership kind name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLogMemberType_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_RoleMembershipLogMemberType__ctor.htm"/>
    public RoleMembershipLogMemberType() { }
}
