using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <summary>Facade class grouping approval methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html"/>
public static class Approval {
    /// <summary>Adds approvers to current approval. Allowed only for states with &quot;ad-hoc&quot; approval enabled (see method TicketState.IsAdHocApproval).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_AddApprovers_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__System_Nullable_System_Int32__Alvao_API_Common_Model_HtmlTextModel_System_Nullable_System_DateTime__"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="approverIds">List of approver IDs (tPerson.iPersonId)</param>
    /// <param name="personId">ID of person who added approvers (tPerson.iPersonId)</param>
    /// <param name="commentForApprover">Comment for approvers</param>
    /// <param name="approvalBegin">Datetime when approvers were added (null = current time).</param>
    public static void AddApprovers(int ticketId, IEnumerable<int> approverIds, int? personId, HtmlTextModel commentForApprover, DateTime? approvalBegin = null) { throw new System.NotImplementedException(); }
    /// <summary>Approves request and changes state according to state settings.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_Approve_System_Int32_Alvao_API_Common_Model_HtmlTextModel_System_Nullable_System_Int32__System_Nullable_System_Int32__System_Boolean_System_Boolean_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="comment">Approval comment</param>
    /// <param name="personId">Person ID (who approved request). If null, current person is set (tPerson.iPersonId)</param>
    /// <param name="nextStep">Next approval step ID. Approval continue with this step after approval.(tApprovalSchemaItem.iApprovalSchemaItemId)</param>
    /// <param name="finishApproval">If true, approval finishes and does not continue to next approval step.</param>
    /// <param name="ignoreRequiredColumns">If true, state changes after approval without checking required columns.</param>
    /// <exception cref="TicketApprovalNotInProgressException">Throws when request approval is not in progress.</exception>
    /// <exception cref="ApprovalException">Throws when next approval step is invalid or when user does not have sufficient rights.</exception>
    public static void Approve(int ticketId, HtmlTextModel comment, int? personId = null, int? nextStep = null, bool finishApproval = false, bool ignoreRequiredColumns = false) { throw new System.NotImplementedException(); }
    /// <summary>Cancel of active approval on ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_Cancel_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <exception cref="TicketApprovalNotInProgressException">Throws when request approval is not in progress.</exception>
    public static void Cancel(int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Cancels selected approvals. Allowed only for states with &quot;ad-hoc&quot; approval enabled (see method TicketState.IsAdHocApproval).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_CancelItems_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="approvalItemIds">List of approval items IDs to cancel(tHdTicketApprovalItem.iHdTicketApprovalItemId)</param>
    public static void CancelItems(int ticketId, IEnumerable<int> approvalItemIds) { throw new System.NotImplementedException(); }
    /// <summary>Starts request approval by person.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_EnterByPerson_System_Int32_System_Int32_System_Double_System_Nullable_System_Int32__Alvao_API_Common_Model_HtmlTextModel_System_Nullable_System_DateTime__"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="approverPersonId">Approver person ID (tPerson.iPersonId)</param>
    /// <param name="expirationHours">Approval expiration hours</param>
    /// <param name="personId">Person ID (who started approval)(tPerson.iPersonId)</param>
    /// <param name="approvalNotice">Comment for approver</param>
    /// <param name="approvalBegin">Approval start time (UTC). If null, current time is set.</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId or person with approverPersonId does not exist.</exception>
    /// <exception cref="ApprovalInProgressException">Throws when request with ticketId is already in approval.</exception>
    /// <returns>Approval step ID (tHdTicketApprovalItem.iHdTicketApprovalItemId)</returns>
    public static int EnterByPerson(int ticketId, int approverPersonId, double expirationHours, int? personId, HtmlTextModel approvalNotice, DateTime? approvalBegin = null) { throw new System.NotImplementedException(); }
    /// <summary>Starts request approval with scheme.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_EnterBySchema_System_Int32_System_Int32_System_Nullable_System_Int32__Alvao_API_Common_Model_HtmlTextModel_System_Nullable_System_DateTime__System_Nullable_System_Int32__"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="schemaId">Approval scheme ID (tApprovalSchema.iApprovalSchemaId)</param>
    /// <param name="personId">Person ID (who started approval)(tPerson.iPersonId)</param>
    /// <param name="approvalNotice">Comment for approver</param>
    /// <param name="approvalBegin">Approval start time (UTC). If null, current time is set.</param>
    /// <param name="initialSchemaStep">Approval starts with this step. If provided step does not exist or there is nobody to approve it, approval does not start.(tApprovalSchemaItem.iApprovalSchemaItemId)</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId or schema with schemaId does not exist.</exception>
    /// <exception cref="ApprovalInProgressException">Throws when request is already in approval.</exception>
    /// <returns>Approval step ID (tHdTicketApprovalItem.iHdTicketApprovalItemId)</returns>
    public static int EnterBySchema(int ticketId, int schemaId, int? personId, HtmlTextModel approvalNotice, DateTime? approvalBegin = null, int? initialSchemaStep = null) { throw new System.NotImplementedException(); }
    /// <summary>Expires currently active approval step on ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_Expire_System_Int32_System_Boolean_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="ignoreRequiredColumns">If true, state changes after cancelation without checking required columns.</param>
    /// <exception cref="TicketApprovalNotInProgressException">Throws when request approval is not in progress.</exception>
    public static void Expire(int ticketId, bool ignoreRequiredColumns = false) { throw new System.NotImplementedException(); }
    /// <summary>Returns approval item with provided ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_GetApprovalItemById_System_Int32_"/>
    /// <param name="approvalItemId">Approval item ID (tHdTicketApprovalItem.iHdTicketApprovalItemId)</param>
    public static tHdTicketApprovalItem GetApprovalItemById(int approvalItemId) { throw new System.NotImplementedException(); }
    /// <summary>Returns approval items for current approval (shown on &quot;Current approval&quot; tab in ticket detail).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_GetCurrentApprovalItems_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static IEnumerable<tHdTicketApprovalItem> GetCurrentApprovalItems(int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Gets list of ticket IDs with approval ready for expiration.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_GetTicketIdsForExpiration"/>
    /// <returns>List of request IDs (tHdTicket.iHdTicketId)</returns>
    public static IEnumerable<int> GetTicketIdsForExpiration() { throw new System.NotImplementedException(); }
    /// <summary>Rejects request and changes state according to state settings.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Approval.html#Alvao_API_SD_Approval_Reject_System_Int32_Alvao_API_Common_Model_HtmlTextModel_System_Nullable_System_Int32__System_Boolean_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="comment">Approval comment</param>
    /// <param name="personId">Person ID (who rejected request). If null, current person is set (tPerson.iPersonId)</param>
    /// <param name="ignoreRequiredColumns">If true, state changes after rejection without checking required columns.</param>
    /// <exception cref="TicketApprovalNotInProgressException">Throws when request approval is not in progress.</exception>
    /// <exception cref="ApprovalException">Throws when user does not have sufficient rights.</exception>
    public static void Reject(int ticketId, HtmlTextModel comment, int? personId = null, bool ignoreRequiredColumns = false) { throw new System.NotImplementedException(); }
}
