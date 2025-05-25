using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of approval step statuses.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItemResult.html"/>
[Table("dbo.tHdTicketApprovalItemResult")]
public class tHdTicketApprovalItemResult {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItemResult.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItemResult_iHdTicketApprovalItemResultId"/>
    [ExplicitKey]
    public virtual int iHdTicketApprovalItemResultId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItemResult.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItemResult_sHdTicketApprovalItemResult"/>
    public virtual string sHdTicketApprovalItemResult { get; set; }
}
