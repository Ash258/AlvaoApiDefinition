using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>You can define custom actions by implementing the ITicketApprovalAutoAction interface in application scripts. Automatic actions are only called for manually triggered approvals with automatic status transition disabled. In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.</summary>
/// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions"/>
public interface ITicketApprovalAutoAction {
    /// <summary>Custom action based on ticket approval. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#onapproved"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the ongoing database transaction.</param>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId).</param>
    /// <param name="approvalItemId">approval step ID (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>
    void OnApproved(SqlConnection con, SqlTransaction trans, int ticketId, int approvalItemId);
    /// <summary>Custom action based on the approval of the ticket rejection. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#onrejected"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the ongoing database transaction.</param>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId).</param>
    /// <param name="approvalItemId">approval step ID (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>
    void OnRejected(SqlConnection con, SqlTransaction trans, int ticketId, int approvalItemId);
    /// <summary>Custom action based on adding a ticket approver. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#onapproveradded"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the ongoing database transaction.</param>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId).</param>
    /// <param name="approvalItemId">approvalItemIds - List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>
    void OnApproverAdded(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds);
    /// <summary>Custom action based on the removal of the ticket approver. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#onapprovercanceled"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the ongoing database transaction.</param>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId).</param>
    /// <param name="approvalItemId">List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>
    void OnApproverCanceled(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds);
}
