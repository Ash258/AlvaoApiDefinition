using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <summary>Facade class grouping approval methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Approval.htm"/>
public static class Approval {

    /// <summary>Adds approvers to current approval. Allowed only for states with "ad-hoc" approval enabled (see method TicketState.IsAdHocApproval).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_AddApprovers.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="approverIds">List of approver IDs (tPerson.iPersonId)</param>
    /// <param name="personId">ID of person who added approvers (tPerson.iPersonId)</param>
    /// <param name="commentForApprover">Comment for approvers</param>
    /// <param name="approvalBegin">Datetime when approvers were added (null = current time).</param>
    public static void AddApprovers(
        int ticketId,
        IEnumerable<int> approverIds,
        int? personId,
        HtmlTextModel commentForApprover,
        DateTime? approvalBegin = null
    ) { throw new System.NotImplementedException(); }

    /// <summary>Approves request and changes state according to state settings.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_Approve.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="comment">Approval comment</param>
    /// <param name="personId">Person ID (who approved request). If null, current person is set (tPerson.iPersonId)</param>
    /// <param name="nextStep">Next approval step ID. Approval continue with this step after approval.(tApprovalSchemaItem.iApprovalSchemaItemId)</param>
    /// <param name="finishApproval">If true, approval finishes and does not continue to next approval step.</param>
    /// <param name="ignoreRequiredColumns">If true, state changes after approval without checking required columns.</param>
    public static void Approve(
        int ticketId,
        HtmlTextModel comment,
        int? personId = null,
        int? nextStep = null,
        bool finishApproval = false,
        bool ignoreRequiredColumns = false
    ) { throw new System.NotImplementedException(); }

    /// <summary>Cancel of active approval on ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_Cancel.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static void Cancel(
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Cancels selected approvals. Allowed only for states with "ad-hoc" approval enabled (see method TicketState.IsAdHocApproval).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_CancelItems.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="approvalItemIds">List of approval items IDs to cancel(tHdTicketApprovalItem.iHdTicketApprovalItemId)</param>
    public static void CancelItems(
        int ticketId,
        IEnumerable<int> approvalItemIds
    ) { throw new System.NotImplementedException(); }

    /// <summary>Starts request approval by person.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_EnterByPerson.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="approverPersonId">Approver person ID (tPerson.iPersonId)</param>
    /// <param name="expirationHours">Approval expiration hours</param>
    /// <param name="personId">Person ID (who started approval)(tPerson.iPersonId)</param>
    /// <param name="approvalNotice">Comment for approver</param>
    /// <param name="approvalBegin">Approval start time (UTC). If null, current time is set.</param>
    public static int EnterByPerson(
        int ticketId,
        int approverPersonId,
        double expirationHours,
        int? personId,
        HtmlTextModel approvalNotice,
        DateTime? approvalBegin = null
    ) { throw new System.NotImplementedException(); }

    /// <summary>Starts request approval with scheme.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_EnterBySchema.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="schemaId">Approval scheme ID (tApprovalSchema.iApprovalSchemaId)</param>
    /// <param name="personId">Person ID (who started approval)(tPerson.iPersonId)</param>
    /// <param name="approvalNotice">Comment for approver</param>
    /// <param name="approvalBegin">Approval start time (UTC). If null, current time is set.</param>
    /// <param name="initialSchemaStep">Approval starts with this step. If provided step does not exist or there is nobody to approve it, approval does not start.(tApprovalSchemaItem.iApprovalSchemaItemId)</param>
    public static int EnterBySchema(
        int ticketId,
        int schemaId,
        int? personId,
        HtmlTextModel approvalNotice,
        DateTime? approvalBegin = null,
        int? initialSchemaStep = null
    ) { throw new System.NotImplementedException(); }

    /// <summary>Expires currently active approval step on ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_Expire.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="ignoreRequiredColumns">If true, state changes after cancelation without checking required columns.</param>
    public static void Expire(
        int ticketId,
        bool ignoreRequiredColumns = false
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns approval item with provided ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_GetApprovalItemById.htm"/>
    ///
    /// <param name="approvalItemId">Approval item ID (tHdTicketApprovalItem.iHdTicketApprovalItemId)</param>
    public static tHdTicketApprovalItem GetApprovalItemById(
        int approvalItemId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns approval items for current approval (shown on "Current approval" tab in ticket detail).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_GetCurrentApprovalItems.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static IEnumerable<tHdTicketApprovalItem> GetCurrentApprovalItems(
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Gets list of ticket IDs with approval ready for expiration.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_GetTicketIdsForExpiration.htm"/>
    public static IEnumerable<int> GetTicketIdsForExpiration() { throw new System.NotImplementedException(); }

    /// <summary>Rejects request and changes state according to state settings.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Approval_Reject.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="comment">Approval comment</param>
    /// <param name="personId">Person ID (who rejected request). If null, current person is set (tPerson.iPersonId)</param>
    /// <param name="ignoreRequiredColumns">If true, state changes after rejection without checking required columns.</param>
    public static void Reject(
        int ticketId,
        HtmlTextModel comment,
        int? personId = null,
        bool ignoreRequiredColumns = false
    ) { throw new System.NotImplementedException(); }
}
