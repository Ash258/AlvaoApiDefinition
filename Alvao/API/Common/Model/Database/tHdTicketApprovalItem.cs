using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket approval step.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html"/>
[Table("dbo.tHdTicketApprovalItem")]
public class tHdTicketApprovalItem {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.ApprovalResult.html#fields"/>
    public enum ApprovalResult {
        NA = 1,
        Accepted = 2,
        Rejected = 3,
        Expired = 4,
        Canceled = 5,
    }
    /// <summary>Approverâs comment in HTML</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_ApprovalItemNotesHtml"/>
    public virtual string ApprovalItemNotesHtml { get; set; }
    /// <summary>Identifier of the substitute who actually made the approval in the approverâs absence (see tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_DeputyApproverPersonId"/>
    public virtual int? DeputyApproverPersonId { get; set; }
    /// <summary>Report for approvers (see tAct.iActId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_MessageForApproverActId"/>
    public virtual int MessageForApproverActId { get; set; }
    /// <summary>Date and time of commencement of step approval.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_Started"/>
    public virtual DateTime? Started { get; set; }
    /// <summary>Date and time after which approval should expire.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_dExpiration"/>
    public virtual DateTime? dExpiration { get; set; }
    /// <summary>Date and time of step completion</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_dHdTicketApprovalItem"/>
    public virtual DateTime? dHdTicketApprovalItem { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_iHdTicketApprovalItemId"/>
    [Key]
    public virtual int iHdTicketApprovalItemId { get; set; }
    /// <summary>Step of the approval scheme governing this approval step, see tHdTicketApprovalSchemaItem.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemApprovalSchemaItemId"/>
    public virtual int? liHdTicketApprovalItemApprovalSchemaItemId { get; set; }
    /// <summary>Record of ongoing approval in a ticket, see tHdTicketApproval.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemHdTicketApprovalId"/>
    public virtual int liHdTicketApprovalItemHdTicketApprovalId { get; set; }
    /// <summary>Status and/or results of approval (see tHdTicketApprovalItemResult)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemHdTicketApprovalItemResultId"/>
    public virtual int liHdTicketApprovalItemHdTicketApprovalItemResultId { get; set; }
    /// <summary>Approver (see tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemPersonId"/>
    public virtual int? liHdTicketApprovalItemPersonId { get; set; }
    /// <summary>Approverâs comment</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_mHdTicketApprovalItemNotes"/>
    public virtual string mHdTicketApprovalItemNotes { get; set; }
}
