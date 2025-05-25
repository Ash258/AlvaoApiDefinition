using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging of changes in membership in groups.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html"/>
[Table("dbo.RoleMembershipLog")]
public class RoleMembershipLog {
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_Group"/>
    public virtual string Group { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>User or group name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_Member"/>
    public virtual string Member { get; set; }
    /// <summary>Kind of membership in the group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_MemberTypeId"/>
    public virtual int MemberTypeId { get; set; }
    /// <summary>Logged-in user name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_ModifiedBy"/>
    public virtual string ModifiedBy { get; set; }
    /// <summary>Operation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_OperationId"/>
    public virtual int OperationId { get; set; }
    /// <summary>Date and time of the operation execution.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RoleMembershipLog.html#Alvao_API_Common_Model_Database_RoleMembershipLog_TimeStamp"/>
    public virtual DateTime TimeStamp { get; set; }
}
