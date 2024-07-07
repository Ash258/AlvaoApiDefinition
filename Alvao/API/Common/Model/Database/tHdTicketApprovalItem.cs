using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket approval step.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdTicketApprovalItem.htm"/>
[TableAttribute("dbo.tHdTicketApprovalItem")]
public class tHdTicketApprovalItem
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_ApprovalResult.htm"/>
    public enum ApprovalResult
    {
        NA = 1,
        Accepted = 2,
        Rejected = 3,
        Expired = 4,
        Canceled = 5,
    }
    /// <summary>Approver’s comment in HTML</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_ApprovalItemNotesHtml.htm"/>
    public virtual string ApprovalItemNotesHtml { get; set; }
    /// <summary>Identifier of the substitute who actually made the approval in the approver’s absence (see tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_DeputyApproverPersonId.htm"/>
    public virtual int? DeputyApproverPersonId { get; set; }
    /// <summary>Date and time after which approval should expire.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_dExpiration.htm"/>
    public virtual DateTime? dExpiration { get; set; }
    /// <summary>Date and time of step completion</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_dHdTicketApprovalItem.htm"/>
    public virtual DateTime? dHdTicketApprovalItem { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_iHdTicketApprovalItemId.htm"/>
    [KeyAttribute]
    public virtual int iHdTicketApprovalItemId { get; set; }
    /// <summary>Step of the approval scheme governing this approval step, see tHdTicketApprovalSchemaItem.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemApprovalSchemaItemId.htm"/>
    public virtual int? liHdTicketApprovalItemApprovalSchemaItemId { get; set; }
    /// <summary>Record of ongoing approval in a ticket, see tHdTicketApproval.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemHdTicketApprovalId.htm"/>
    public virtual int liHdTicketApprovalItemHdTicketApprovalId { get; set; }
    /// <summary>Status and/or results of approval (see tHdTicketApprovalItemResult)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemHdTicketApprovalItemResultId.htm"/>
    public virtual int liHdTicketApprovalItemHdTicketApprovalItemResultId { get; set; }
    /// <summary>Approver (see tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemPersonId.htm"/>
    public virtual int? liHdTicketApprovalItemPersonId { get; set; }
    /// <summary>Report for approvers (see tAct.iActId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_MessageForApproverActId.htm"/>
    public virtual int MessageForApproverActId { get; set; }
    /// <summary>Approver’s comment</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_mHdTicketApprovalItemNotes.htm"/>
    public virtual string mHdTicketApprovalItemNotes { get; set; }
    /// <summary>Date and time of commencement of step approval.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApprovalItem_Started.htm"/>
    public virtual DateTime? Started { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tHdTicketApprovalItem__ctor.htm"/>
    public tHdTicketApprovalItem() { }
}
