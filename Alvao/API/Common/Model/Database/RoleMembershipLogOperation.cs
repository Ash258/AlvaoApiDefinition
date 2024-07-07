using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Executed operation which is logged.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RoleMembershipLogOperation.htm"/>
[TableAttribute("dbo.RoleMembershipLogOperation")]
public class RoleMembershipLogOperation
{
    /// <summary>Operation ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLogOperation_Id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Operation name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLogOperation_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_RoleMembershipLogOperation__ctor.htm"/>
    public RoleMembershipLogOperation() { }
}
