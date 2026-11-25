using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Registered webhooks integrating Alvao with other applications.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html"/>
[Table("dbo.Webhook")]
public class Webhook {
    /// <summary>Ticket field ID for wich the webhook should be invoked (tColumn.iColumnId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_ColumnId"/>
    /// <remarks>Column <c>ColumnId</c>: int, null. References <see cref="tColumn"/>.</remarks>
    public virtual int? ColumnId { get; set; }
    /// <summary>Creation date</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_Created"/>
    /// <remarks>Column <c>Created</c>: datetime, not null.</remarks>
    public virtual DateTime Created { get; set; }
    /// <summary>1 = the webhook is enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_Enabled"/>
    /// <remarks>Column <c>Enabled</c>: bit, not null.</remarks>
    public virtual bool Enabled { get; set; }
    /// <summary>Error message at the last invocation.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_ErrorMessage"/>
    /// <remarks>Column <c>ErrorMessage</c>: nvarchar(max), null.</remarks>
    public virtual string ErrorMessage { get; set; }
    /// <summary>Last invocation date</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_LastInvoked"/>
    /// <remarks>Column <c>LastInvoked</c>: datetime, null.</remarks>
    public virtual DateTime? LastInvoked { get; set; }
    /// <summary>ID of the source object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_MovedFromNodeId"/>
    /// <remarks>Column <c>MovedFromNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? MovedFromNodeId { get; set; }
    /// <summary>
    /// ID of the destination object for whose subtree the webhook should be invoked (tblNode.intNodeId).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_MovedToNodeId"/>
    /// <remarks>Column <c>MovedToNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? MovedToNodeId { get; set; }
    /// <summary>Webhook name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Object type in which the webhook should be invoked (tblClass.intClassId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_NodeClassId"/>
    /// <remarks>Column <c>NodeClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? NodeClassId { get; set; }
    /// <summary>Object property kind in which the webhook should be invoked (tblKind.intKindId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_NodePropertyKindId"/>
    /// <remarks>Column <c>NodePropertyKindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? NodePropertyKindId { get; set; }
    /// <summary>New object property value in which the webhook should be invoked.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_NodePropertyNewValue"/>
    /// <remarks>Column <c>NodePropertyNewValue</c>: nvarchar(255), null.</remarks>
    public virtual string NodePropertyNewValue { get; set; }
    /// <summary>ID of the parent object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_ParentNodeId"/>
    /// <remarks>Column <c>ParentNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? ParentNodeId { get; set; }
    /// <summary>Ticket service for which the webhook should be invoked (tHdSection.iHdSectionId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_SectionId"/>
    /// <remarks>Column <c>SectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? SectionId { get; set; }
    /// <summary>Ticket status in which the webhook should be invoked (TicketState.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_TicketStateId"/>
    /// <remarks>Column <c>TicketStateId</c>: int, null. References <see cref="TicketState"/>.</remarks>
    public virtual int? TicketStateId { get; set; }
    /// <summary>Ticket process for which the webhook should be invoked (TicketType.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_TicketTypeId"/>
    /// <remarks>Column <c>TicketTypeId</c>: int, null. References <see cref="TicketType"/>.</remarks>
    public virtual int? TicketTypeId { get; set; }
    /// <summary>Webhook topic ID (WebhookTopic.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_TopicId"/>
    /// <remarks>Column <c>TopicId</c>: int, not null. References <see cref="WebhookTopic"/>.</remarks>
    public virtual int TopicId { get; set; }
    /// <summary>Webhook callback URL</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_Url"/>
    /// <remarks>Column <c>Url</c>: nvarchar(2048), not null.</remarks>
    public virtual string Url { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }

    /// <summary>Returns a string that represents the current object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Webhook.html#Alvao_API_Common_Model_Database_Webhook_ToString"/>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() { throw new NotImplementedException(); }
}
