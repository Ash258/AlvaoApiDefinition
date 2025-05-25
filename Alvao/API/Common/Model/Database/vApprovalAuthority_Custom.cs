using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Current ticket approvers according to custom approval processes. The customer can define custom contents for this view.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vApprovalAuthority_Custom.html"/>
[Table("dbo.vApprovalAuthority_Custom")]
public class vApprovalAuthority_Custom {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vApprovalAuthority_Custom.html#Alvao_API_Common_Model_Database_vApprovalAuthority_Custom_liHdTicketId"/>
    public virtual int? liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vApprovalAuthority_Custom.html#Alvao_API_Common_Model_Database_vApprovalAuthority_Custom_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
