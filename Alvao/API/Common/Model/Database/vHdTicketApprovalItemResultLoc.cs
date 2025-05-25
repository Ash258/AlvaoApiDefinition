using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Results of approval steps in all languages used.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketApprovalItemResultLoc.html"/>
[Table("dbo.vHdTicketApprovalItemResultLoc")]
public class vHdTicketApprovalItemResultLoc {
    /// <summary>Language localization ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketApprovalItemResultLoc.html#Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc_ApprovalItemResultLocaleId"/>
    public virtual int ApprovalItemResultLocaleId { get; set; }
    /// <summary>Localized approving result</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketApprovalItemResultLoc.html#Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc_LocalizedResult"/>
    public virtual string LocalizedResult { get; set; }
    /// <summary>Approving result ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketApprovalItemResultLoc.html#Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc_iHdTicketApprovalItemResultId"/>
    public virtual int iHdTicketApprovalItemResultId { get; set; }
    /// <summary>Approving result</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketApprovalItemResultLoc.html#Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc_sHdTicketApprovalItemResult"/>
    public virtual string sHdTicketApprovalItemResult { get; set; }
}
