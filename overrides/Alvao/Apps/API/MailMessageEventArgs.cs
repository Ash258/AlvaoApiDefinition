using Rebex.Mail;

namespace Alvao.Apps.API;

/// <summary>!!!CAUTION: This class is not documented. Its shape is taken from the Alvao 26 application templates.<br/><br/>Parameters of mail message auto action methods.</summary>
public class MailMessageEventArgs {
    /// <summary>The received message.</summary>
    public MailMessage Message { get; set; }
    /// <summary>The service ID (tHdSection.iSectionId) which the message was loaded to.</summary>
    public int SectionId { get; set; }
    /// <summary>ID of the ticket (tHdTicket.iHdTicketId) to which the message belongs according to the subject, or zero if it is a new ticket creation.</summary>
    public int TicketId { get; set; }
    /// <summary>Message sender ID (tPerson.iPersonId), or Host account, if the message sender is not found among the users.</summary>
    public int FromPersonId { get; set; }
}
