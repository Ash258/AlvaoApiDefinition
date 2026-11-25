namespace Alvao.Apps.API;

/// <summary>By implementing the IMailMessageAutoAction interface in the application script you can define custom actions when loading a message from the service mailbox before saving the message to the log of an existing ticket or before creating a new ticket. In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.</summary>
/// <see href="https://doc.alvao.com/en/26/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions"/>
public interface IMailMessageAutoAction {
    /// <summary>The actual action can be performed when loading a message from the service mailbox before saving the message to the log of an existing ticket or before creating a new ticket. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/26/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions#onmessagereceived"/>
    /// <param name="e">The received message, the service and ticket it belongs to and its sender.</param>
    /// <param name="cancellationToken">Token to cancel the asynchronous operation.</param>
    /// <returns>Return true or false indicating whether or not the message should continue to be processed by default. For an example use case, see the AssignToSolverByEmail application template.</returns>
    Task<bool> OnMessageReceivedAsync(MailMessageEventArgs e, CancellationToken cancellationToken);
}
