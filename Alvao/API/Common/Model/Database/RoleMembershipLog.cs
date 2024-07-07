using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Logging of changes in membership in groups.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RoleMembershipLog.htm"/>
[TableAttribute("dbo.RoleMembershipLog")]
public class RoleMembershipLog
{
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLog_Group.htm"/>
    public virtual string Group { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLog_Id.htm"/>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>User or group name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLog_Member.htm"/>
    public virtual string Member { get; set; }
    /// <summary>Kind of membership in the group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLog_MemberTypeId.htm"/>
    public virtual int MemberTypeId { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLog_ModifiedBy.htm"/>
    public virtual string ModifiedBy { get; set; }
    /// <summary>Operation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLog_OperationId.htm"/>
    public virtual int OperationId { get; set; }
    /// <summary>Date and time of the operation execution.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RoleMembershipLog_TimeStamp.htm"/>
    public virtual DateTime TimeStamp { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_RoleMembershipLog__ctor.htm"/>
    public RoleMembershipLog() { }
}
