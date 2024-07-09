using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>
/// You can define custom actions by implementing the ITicketApprovalAutoAction interface in application scripts.
/// Automatic actions are only called for manually triggered approvals with automatic status transition disabled.
/// In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.
/// Tip: To store properties and action settings, we recommend defining the Settings class in a separate script that you create from the Class Library template.
/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions"/>
public interface ITicketApprovalAutoAction
{
    public string Name { get; set; }

    /// <summary>Custom action based on ticket approval. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the ongoing database transaction.</param>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)..</param>
    /// <param name="approvalItemIds">List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#OnApproved"/>
    void OnApproved(SqlConnection con, SqlTransaction trans, int ticketId, int approvalItemId);

    /// <summary>Custom action based on the approval of the ticket rejection. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the ongoing database transaction.</param>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)..</param>
    /// <param name="approvalItemIds">List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#OnApproverAdded"/>
    void OnApproverAdded(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds);

    /// <summary>Custom action based on the removal of the ticket approver. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the ongoing database transaction.</param>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)..</param>
    /// <param name="approvalItemIds">List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#OnApproverCanceled"/>
     void OnApproverCanceled(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds);
}
