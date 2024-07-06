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
    public virtual string Group { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>User or group name.</summary>
    public virtual string Member { get; set; }
    /// <summary>Kind of membership in the group.</summary>
    public virtual int MemberTypeId { get; set; }
    /// <summary>Logged-in user name.</summary>
    public virtual string ModifiedBy { get; set; }
    /// <summary>Operation.</summary>
    public virtual int OperationId { get; set; }
    /// <summary>Date and time of the operation execution.</summary>
    public virtual DateTime TimeStamp { get; set; }

    public RoleMembershipLog() { }
}
