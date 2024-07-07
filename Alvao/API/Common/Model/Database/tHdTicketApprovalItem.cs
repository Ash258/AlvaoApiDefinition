using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket approval step.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdTicketApprovalItem.htm"/>
[TableAttribute("dbo.tHdTicketApprovalItem")]
public class tHdTicketApprovalItem
{
    public enum ApprovalResult
    {
        NA = 1,
        Accepted = 2,
        Rejected = 3,
        Expired = 4,
        Canceled = 5,
    }

    /// <summary>Approver’s comment in HTML</summary>
    public virtual string ApprovalItemNotesHtml { get; set; }
    /// <summary>Identifier of the substitute who actually made the approval in the approver’s absence (see tPerson.iPersonId)</summary>
    public virtual int? DeputyApproverPersonId { get; set; }
    /// <summary>Date and time after which approval should expire.</summary>
    public virtual DateTime? dExpiration { get; set; }
    /// <summary>Date and time of step completion</summary>
    public virtual DateTime? dHdTicketApprovalItem { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int iHdTicketApprovalItemId { get; set; }
    /// <summary>Step of the approval scheme governing this approval step, see tHdTicketApprovalSchemaItem.</summary>
    public virtual int? liHdTicketApprovalItemApprovalSchemaItemId { get; set; }
    /// <summary>Record of ongoing approval in a ticket, see tHdTicketApproval.</summary>
    public virtual int liHdTicketApprovalItemHdTicketApprovalId { get; set; }
    /// <summary>Status and/or results of approval (see tHdTicketApprovalItemResult)</summary>
    public virtual int liHdTicketApprovalItemHdTicketApprovalItemResultId { get; set; }
    /// <summary>Approver (see tPerson.iPersonId)</summary>
    public virtual int? liHdTicketApprovalItemPersonId { get; set; }
    /// <summary>Report for approvers (see tAct.iActId)</summary>
    public virtual int MessageForApproverActId { get; set; }
    /// <summary>Approver’s comment</summary>
    public virtual string mHdTicketApprovalItemNotes { get; set; }
    /// <summary>Date and time of commencement of step approval.</summary>
    public virtual DateTime? Started { get; set; }

    public tHdTicketApprovalItem() { }
}
