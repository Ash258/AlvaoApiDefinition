using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>By implementing the IActAutoAction interface in a application script, you can define custom actions when creating an event on a ticket. In the newly created script, set the value of the Name property (the name of the automatic action) in the constructor of the action class.</summary>
/// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions"/>
public interface IActAutoAction {
    /// <summary>Custom action based on event modification. In the implemented method, define both the conditions for executing the operations and the event operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#onactchanged"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the database transaction in progress.</param>
    /// <param name="actId">The ID of the event (tAct.iActId) that was changed.</param>
    /// <param name="personId">The ID of the user (tPerson.iPersonId) who changed the event.</param>
    /// <param name="properties">the changed event fields separated by a comma(table.column).</param>
    void OnActChanged(SqlConnection con, SqlTransaction trans, int actId, int personId, string properties);
    /// <summary>Custom action based on event creation. In the implemented method, define both the conditions for executing the operations and the event operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#onactcreated"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the database transaction in progress.</param>
    /// <param name="actId">The ID of the event (tAct.iActId) that was changed.</param>
    /// <param name="personId">The ID of the user (tPerson.iPersonId) who changed the event.</param>
    void OnActCreated(SqlConnection con, SqlTransaction trans, int actId, int personId);
    /// <summary>Custom action based on event removal. In the implemented method, define both the conditions for executing the operations and the event operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#onactremoved"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="trans">SqlTransaction of the database transaction in progress.</param>
    /// <param name="actId">The ID of the event (tAct.iActId) that was changed.</param>
    /// <param name="personId">The ID of the user (tPerson.iPersonId) who changed the event.</param>
    void OnActRemoved(SqlConnection con, SqlTransaction trans, int actId, int personId);
}
