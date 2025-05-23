using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing the IActAutoAction interface in a application script, you can define custom actions when creating an event on a ticket.
/// In the newly created script, set the value of the Name property (the name of the automatic action) in the constructor of the action class.
/// Tip: To store properties and action settings, we recommend defining the Settings class in a separate script that you create from the Class Library template.
/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions"/>
public interface IActAutoAction
{
    public string Name { get; set; }

    /// <summary>Custom action based on event modification. In the implemented method, define both the conditions for executing the operations and the event operations themselves.</summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the database transaction in progress.</param>
    /// <param name="actId">The ID of the event (tAct.iActId) that was changed.</param>
    /// <param name="personId">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>
    /// <param name="properties">The changed ticket items separated by a comma (table.column).</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#OnActChanged"/>
    void OnActChanged(SqlConnection con, SqlTransaction trans, int actId, int personId, string properties);

    /// <summary>Custom action based on the creation of a ticket. In the implemented method, define both the conditions for executing the operations and the operations with the ticket itself.</summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the database transaction in progress.</param>
    /// <param name="actId">ID of the newly created event (tAct.iActId).</param>
    /// <param name="personId">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#OnActCreated"/>
    void OnActCreated(SqlConnection con, SqlTransaction trans, int actId, int personId);

    /// <summary>Custom action based on event removal. In the implemented method, define both the conditions for executing the operations and the operations with the ticket itself.</summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the database transaction in progress.</param>
    /// <param name="actId">ID of the newly created event (tAct.iActId).</param>
    /// <param name="personId">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#OnActRemoved"/>
    void OnActRemoved(SqlConnection con, SqlTransaction trans, int actId, int personId);
}
