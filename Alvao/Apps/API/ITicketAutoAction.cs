using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing the ITicketAutoAction interface in a application script, you can define custom actions based on a change in the value of a ticket item or respond to a newly created ticket.
/// In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.
/// Tip: To store properties and action settings, we recommend defining the Settings class in a separate script that you create from the Class Library template.
/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-custom-actions"/>
public interface ITicketAutoAction
{
    public string Name { get; set; }

    /// <summary>Custom action based on a change in the value of a ticket item (custom/system). In the implemented method, define both the conditions for performing the operations and the operations themselves.</summary>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the database transaction in progress.</param>
    /// <param name="ticketId">The ID of the ticket (tHdTicket.iHdTicketId) to which the custom action applies.</param>
    /// <param name="personId">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>
    /// <param name="properties">The changed ticket items separated by a comma (table.column).</param>
    void OnTicketChanged(SqlConnection con, SqlTransaction trans, int ticketId, int personId, string properties);

    /// <summary>Custom action based on the creation of a ticket. In the implemented method, define both the conditions for executing the operations and the operations with the ticket itself.</summary>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the database transaction in progress.</param>
    /// <param name="ticketId">The ID of the ticket (tHdTicket.iHdTicketId) to which the custom action applies.</param>
    /// <param name="personId">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>
    void OnTicketCreated(SqlConnection con, SqlTransaction trans, int ticketId, int personId);
}
