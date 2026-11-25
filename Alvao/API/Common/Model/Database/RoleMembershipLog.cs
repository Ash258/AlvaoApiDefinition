using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging of changes in membership in groups.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html"/>
[Table("dbo.RoleMembershipLog")]
public class RoleMembershipLog {
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_Group"/>
    /// <remarks>Column <c>Group</c>: nvarchar(255), not null.</remarks>
    public virtual string Group { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>User or group name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_Member"/>
    /// <remarks>Column <c>Member</c>: nvarchar(255), not null.</remarks>
    public virtual string Member { get; set; }
    /// <summary>Kind of membership in the group.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_MemberTypeId"/>
    /// <remarks>
    /// Column <c>MemberTypeId</c>: int, not null. References <see cref="RoleMembershipLogMemberType"/>.
    /// </remarks>
    public virtual int MemberTypeId { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_ModifiedBy"/>
    /// <remarks>Column <c>ModifiedBy</c>: nvarchar(255), not null.</remarks>
    public virtual string ModifiedBy { get; set; }
    /// <summary>Operation.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_OperationId"/>
    /// <remarks>
    /// Column <c>OperationId</c>: int, not null. References <see cref="RoleMembershipLogOperation"/>.
    /// </remarks>
    public virtual int OperationId { get; set; }
    /// <summary>Date and time of the operation execution.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_TimeStamp"/>
    /// <remarks>Column <c>TimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime TimeStamp { get; set; }
}
