using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Current approvers of tickets that are currently in the process of being approved.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vApprovalAuthority.html"/>
[Table("dbo.vApprovalAuthority")]
public class vApprovalAuthority {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vApprovalAuthority.html#Alvao_API_Common_Model_Database_vApprovalAuthority_liApprovalAuthorityHdTicketId"/>
    public virtual int? liApprovalAuthorityHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vApprovalAuthority.html#Alvao_API_Common_Model_Database_vApprovalAuthority_liApprovalAuthorityPersonId"/>
    public virtual int? liApprovalAuthorityPersonId { get; set; }
}
