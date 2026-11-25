using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket approval step.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html"/>
[Table("dbo.tHdTicketApprovalItem")]
public class tHdTicketApprovalItem {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.ApprovalResult.html#fields"/>
    public enum ApprovalResult {
        NA = 1,
        Accepted = 2,
        Rejected = 3,
        Expired = 4,
        Canceled = 5,
    }

    /// <summary>Approverâs comment in HTML</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_ApprovalItemNotesHtml"/>
    /// <remarks>Column <c>ApprovalItemNotesHtml</c>: nvarchar(max), null.</remarks>
    public virtual string ApprovalItemNotesHtml { get; set; }
    /// <summary>
    /// Identifier of the substitute who actually made the approval in the approverâs absence (see tPerson.iPersonId)
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_DeputyApproverPersonId"/>
    /// <remarks>Column <c>DeputyApproverPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? DeputyApproverPersonId { get; set; }
    /// <summary>Report for approvers (see tAct.iActId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_MessageForApproverActId"/>
    /// <remarks>Column <c>MessageForApproverActId</c>: int, not null. References <see cref="tAct"/>.</remarks>
    public virtual int MessageForApproverActId { get; set; }
    /// <summary>Date and time of commencement of step approval.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_Started"/>
    /// <remarks>Column <c>Started</c>: datetime, null.</remarks>
    public virtual DateTime? Started { get; set; }
    /// <summary>Date and time after which approval should expire.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_dExpiration"/>
    /// <remarks>Column <c>dExpiration</c>: datetime, null.</remarks>
    public virtual DateTime? dExpiration { get; set; }
    /// <summary>Date and time of step completion</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_dHdTicketApprovalItem"/>
    /// <remarks>Column <c>dHdTicketApprovalItem</c>: datetime, null.</remarks>
    public virtual DateTime? dHdTicketApprovalItem { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_iHdTicketApprovalItemId"/>
    /// <remarks>Column <c>iHdTicketApprovalItemId</c>: int, not null.</remarks>
    [Key]
    public virtual int iHdTicketApprovalItemId { get; set; }
    /// <summary>Step of the approval scheme governing this approval step, see tHdTicketApprovalSchemaItem.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemApprovalSchemaItemId"/>
    /// <remarks>
    /// Column <c>liHdTicketApprovalItemApprovalSchemaItemId</c>: int, null. References <see
    /// cref="tApprovalSchemaItem"/>.
    /// </remarks>
    public virtual int? liHdTicketApprovalItemApprovalSchemaItemId { get; set; }
    /// <summary>Record of ongoing approval in a ticket, see tHdTicketApproval.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemHdTicketApprovalId"/>
    /// <remarks>
    /// Column <c>liHdTicketApprovalItemHdTicketApprovalId</c>: int, not null. References <see
    /// cref="tHdTicketApproval"/>.
    /// </remarks>
    public virtual int liHdTicketApprovalItemHdTicketApprovalId { get; set; }
    /// <summary>Status and/or results of approval (see tHdTicketApprovalItemResult)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemHdTicketApprovalItemResultId"/>
    /// <remarks>
    /// Column <c>liHdTicketApprovalItemHdTicketApprovalItemResultId</c>: int, not null. References <see
    /// cref="tHdTicketApprovalItemResult"/>.
    /// </remarks>
    public virtual int liHdTicketApprovalItemHdTicketApprovalItemResultId { get; set; }
    /// <summary>Approver (see tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_liHdTicketApprovalItemPersonId"/>
    /// <remarks>Column <c>liHdTicketApprovalItemPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liHdTicketApprovalItemPersonId { get; set; }
    /// <summary>Approverâs comment</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApprovalItem.html#Alvao_API_Common_Model_Database_tHdTicketApprovalItem_mHdTicketApprovalItemNotes"/>
    /// <remarks>Column <c>mHdTicketApprovalItemNotes</c>: nvarchar(max), null.</remarks>
    public virtual string mHdTicketApprovalItemNotes { get; set; }
}
