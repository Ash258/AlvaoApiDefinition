namespace Alvao.API.Common;

/// <summary>
/// Facade class grouping webhook methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Webhook.htm"/>
public static class Webhook
{
    /// <summary>Disables webhook.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Webhook_Disable.htm"/>
    /// <param name="webhookId">Webhook ID (Webhook.id)</param>
    public static bool Disable(
        int webhookId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Enables webhook.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Webhook_Enable.htm"/>
    /// <param name="webhookId">Webhook ID (Webhook.id)</param>
    public static bool Enable(
        int webhookId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Calls all webhooks registered for provided object creation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Webhook_WhenObjectCreated.htm"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    public static void WhenObjectCreated(
        int objectId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Calls all webhooks registered for provided object moving.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Webhook_WhenObjectMoved.htm"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="oldParentObjectId">Previous object location. Object ID (tblNode.intNodeId)</param>
    public static void WhenObjectMoved(
        int objectId,
        int? oldParentObjectId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Calls all webhooks registered for provided object property changing.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Webhook_WhenObjectPropertyChanged.htm"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="propertyId">Property ID. Property ID (tblProperty.intPropertyId)</param>
    public static void WhenObjectPropertyChanged(
        int objectId,
        int propertyId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Calls all webhooks registered for provided changed fields on the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Webhook_WhenRequestFieldChanged.htm"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="personId">ID of the author of the change (tPerson.iPersonId)</param>
    /// <param name="changedFields">List of the changed fields in format "table.column", e.g. "tHdTicketCust.Category", "tHdTicket.Priority".</param>
    public static void WhenRequestFieldChanged(
        int ticketId,
        int personId,
        IEnumerable<string> changedFields
    )
    { throw new System.NotImplementedException(); }
}
