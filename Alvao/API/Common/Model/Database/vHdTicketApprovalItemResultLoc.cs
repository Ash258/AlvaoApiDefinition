using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Results of approval steps in all languages used.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc.htm"/>
[TableAttribute("dbo.vHdTicketApprovalItemResultLoc")]
public class vHdTicketApprovalItemResultLoc {
    /// <summary>Language localization ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc_ApprovalItemResultLocaleId.htm"/>
    public virtual int ApprovalItemResultLocaleId { get; set; }
    /// <summary>Approving result ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc_iHdTicketApprovalItemResultId.htm"/>
    public virtual int iHdTicketApprovalItemResultId { get; set; }
    /// <summary>Localized approving result</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc_LocalizedResult.htm"/>
    public virtual string LocalizedResult { get; set; }
    /// <summary>Approving result</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc_sHdTicketApprovalItemResult.htm"/>
    public virtual string sHdTicketApprovalItemResult { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc__ctor.htm"/>
    public vHdTicketApprovalItemResultLoc() { }
}
