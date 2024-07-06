using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Results of approval steps in all languages used.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdTicketApprovalItemResultLoc.htm"/>
[TableAttribute("dbo.vHdTicketApprovalItemResultLoc")]
public class vHdTicketApprovalItemResultLoc
{
    /// <summary>Language localization ID</summary>
    public virtual int ApprovalItemResultLocaleId { get; set; }
    /// <summary>Approving result ID</summary>
    public virtual int iHdTicketApprovalItemResultId { get; set; }
    /// <summary>Localized approving result</summary>
    public virtual string LocalizedResult { get; set; }
    /// <summary>Approving result</summary>
    public virtual string sHdTicketApprovalItemResult { get; set; }

    public vHdTicketApprovalItemResultLoc() { }
}
