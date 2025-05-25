using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Registered webhooks integrating Alvao with other applications.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html"/>
[Table("dbo.Webhook")]
public class Webhook {
    /// <summary>Ticket field ID for wich the webhook should be invoked (tColumn.iColumnId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_ColumnId"/>
    public virtual int? ColumnId { get; set; }
    /// <summary>Creation date</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_Created"/>
    public virtual DateTime Created { get; set; }
    /// <summary>1 = the webhook is enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_Enabled"/>
    public virtual bool Enabled { get; set; }
    /// <summary>Error message at the last invocation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_ErrorMessage"/>
    public virtual string ErrorMessage { get; set; }
    /// <summary>Last invocation date</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_LastInvoked"/>
    public virtual DateTime? LastInvoked { get; set; }
    /// <summary>ID of the source object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_MovedFromNodeId"/>
    public virtual int? MovedFromNodeId { get; set; }
    /// <summary>ID of the destination object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_MovedToNodeId"/>
    public virtual int? MovedToNodeId { get; set; }
    /// <summary>Webhook name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Object type in which the webhook should be invoked (tblClass.intClassId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_NodeClassId"/>
    public virtual int? NodeClassId { get; set; }
    /// <summary>Object property kind in which the webhook should be invoked (tblKind.intKindId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_NodePropertyKindId"/>
    public virtual int? NodePropertyKindId { get; set; }
    /// <summary>New object property value in which the webhook should be invoked.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_NodePropertyNewValue"/>
    public virtual string NodePropertyNewValue { get; set; }
    /// <summary>ID of the parent object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_ParentNodeId"/>
    public virtual int? ParentNodeId { get; set; }
    /// <summary>Ticket service for which the webhook should be invoked (tHdSection.iHdSectionId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_SectionId"/>
    public virtual int? SectionId { get; set; }
    /// <summary>Ticket status in which the webhook should be invoked (TicketState.id).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_TicketStateId"/>
    public virtual int? TicketStateId { get; set; }
    /// <summary>Ticket process for which the webhook should be invoked (TicketType.id).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_TicketTypeId"/>
    public virtual int? TicketTypeId { get; set; }
    /// <summary>Webhook topic ID (WebhookTopic.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_TopicId"/>
    public virtual int TopicId { get; set; }
    /// <summary>Webhook callback URL</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_Url"/>
    public virtual string Url { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_id"/>
    [Key]
    public virtual int id { get; set; }
    /// <summary>Returns a string that represents the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_ToString"/>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() { throw new NotImplementedException(); }
}
