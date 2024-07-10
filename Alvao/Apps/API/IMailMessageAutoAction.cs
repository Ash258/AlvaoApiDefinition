using Microsoft.Data.SqlClient;
using Rebex.Mail;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing the IMailMessageAutoAction interface in the application script you can define custom actions when loading a message from the service mailbox before saving the message to the log of an existing ticket or before creating a new ticket. In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.
/// Tip: To store properties and action settings, we recommend defining the Settings class in a separate script that you create from the Class Library template.
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions"/>
public interface IMailMessageAutoAction
{
    public string Name { get; set; }

    /// <summary>The actual action can be performed when loading a message from the service mailbox before saving the message to the log of an existing ticket or before creating a new ticket. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the ongoing database transaction.</param>
    /// <param name="message">message object.</param>
    /// <param name="sectionId">the service ID (tHdSection.iSectionId) which the message was loaded to.</param>
    /// <param name="ticketId">ID of the ticket (tHdTicket.iHdTicketId) to which the message belongs according to the subject, or zero if it is a new ticket creation.</param>
    /// <param name="fromPersonId">message sender ID (tPerson.iPersonId), or Host account, if the message sender is not found among the users.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions#OnMessageReceived"/>
    bool OnMessageReceived(SqlConnection con, SqlTransaction trans, MailMessage message, int sectionId, int ticketId, int fromPersonId);
}
