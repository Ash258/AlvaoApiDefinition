namespace Alvao.API.Common;

/// <summary>Facade class grouping webhook methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html"/>
public static class Webhook {
    /// <summary>Creates new webhook and returns it's ID (Webhook.id).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_Create_Alvao_API_Common_Model_Database_Webhook_"/>
    /// <param name="webhook">Organization</param>
    /// <returns>Created webhook ID (Webhook.id)</returns>
    public static int Create(Alvao.API.Common.Model.Database.Webhook webhook) { throw new System.NotImplementedException(); }
    /// <summary>Deletes webhook from database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_Delete_Alvao_API_Common_Model_Database_Webhook_"/>
    /// <param name="webhook">Webhook database model to delete.</param>
    /// <returns>True, if the webhook was successfully deleted. False otherwise.</returns>
    public static bool Delete(Alvao.API.Common.Model.Database.Webhook webhook) { throw new System.NotImplementedException(); }
    /// <summary>Disables webhook.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_Disable_System_Int32_"/>
    /// <param name="webhookId">Webhook ID (Webhook.id)</param>
    /// <returns>True, if the webhook was successfully disabled. False otherwise.</returns>
    public static bool Disable(int webhookId) { throw new System.NotImplementedException(); }
    /// <summary>Enables webhook.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_Enable_System_Int32_"/>
    /// <param name="webhookId">Webhook ID (Webhook.id)</param>
    /// <returns>True, if the webhook was successfully enabled. False otherwise.</returns>
    public static bool Enable(int webhookId) { throw new System.NotImplementedException(); }
    /// <summary>Returns webhook database model by its ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_GetById_System_Int32_"/>
    /// <param name="webhookId">Webhook ID (Webhook.id)</param>
    /// <returns>Webhook</returns>
    public static Alvao.API.Common.Model.Database.Webhook GetById(int webhookId) { throw new System.NotImplementedException(); }
    /// <summary>Returns webhook topic database model by its ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_GetTopicById_System_Int32_"/>
    /// <param name="topicId">Webhook topic ID (WebhookTopic.id)</param>
    /// <returns>Webhook topic</returns>
    public static Alvao.API.Common.Model.Database.WebhookTopic GetTopicById(int topicId) { throw new System.NotImplementedException(); }
    /// <summary>Calls all webhooks registered for provided object creation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_WhenObjectCreated_System_Int32_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    public static void WhenObjectCreated(int objectId) { throw new System.NotImplementedException(); }
    /// <summary>Calls all webhooks registered for provided object moving.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_WhenObjectMoved_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="oldParentObjectId">Previous object location. Object ID (tblNode.intNodeId)</param>
    public static void WhenObjectMoved(int objectId, int? oldParentObjectId) { throw new System.NotImplementedException(); }
    /// <summary>Calls all webhooks registered for provided object property changing.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_WhenObjectPropertyChanged_System_Int32_System_Int32_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="propertyKindId">Property kind ID. Property ID (tblKind.intKindId)</param>
    public static void WhenObjectPropertyChanged(int objectId, int propertyKindId) { throw new System.NotImplementedException(); }
    /// <summary>Calls all webhooks registered for provided changed fields on the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Webhook.html#Alvao_API_Common_Webhook_WhenRequestFieldChanged_System_Int32_System_Int32_System_Collections_Generic_IEnumerable_System_String__"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="personId">ID of the author of the change (tPerson.iPersonId)</param>
    /// <param name="changedFields">List of the changed fields in format &quot;table.column&quot;, e.g. &quot;tHdTicketCust.Category&quot;, &quot;tHdTicket.Priority&quot;.</param>
    public static void WhenRequestFieldChanged(int ticketId, int personId, IEnumerable<string> changedFields) { throw new System.NotImplementedException(); }
}
