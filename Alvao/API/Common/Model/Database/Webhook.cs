using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Registered webhooks integrating Alvao with other applications.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Webhook.htm"/>
[TableAttribute("dbo.Webhook")]
public class Webhook
{
    /// <summary>Ticket field ID for wich the webhook should be invoked (tColumn.iColumnId).</summary>
    public virtual int? ColumnId { get; set; }
    /// <summary>Creation date</summary>
    public virtual DateTime Created { get; set; }
    /// <summary>1 = the webhook is enabled, 0 = disabled.</summary>
    public virtual bool Enabled { get; set; }
    /// <summary>Error message at the last invocation.</summary>
    public virtual string ErrorMessage { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Last invocation date</summary>
    public virtual DateTime? LastInvoked { get; set; }
    /// <summary>ID of the source object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    public virtual int? MovedFromNodeId { get; set; }
    /// <summary>ID of the destination object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    public virtual int? MovedToNodeId { get; set; }
    /// <summary>Webhook name</summary>
    public virtual string Name { get; set; }
    /// <summary>Object kind in which the webhook should be invoked (tblClass.intClassId).</summary>
    public virtual int? NodeClassId { get; set; }
    /// <summary>Object property kind in which the webhook should be invoked (tblKind.intKindId).</summary>
    public virtual int? NodePropertyKindId { get; set; }
    /// <summary>New object property value in which the webhook should be invoked.</summary>
    public virtual string NodePropertyNewValue { get; set; }
    /// <summary>ID of the parent object for whose subtree the webhook should be invoked (tblNode.intNodeId).</summary>
    public virtual int? ParentNodeId { get; set; }
    /// <summary>Ticket service for which the webhook should be invoked (tHdSection.iHdSectionId).</summary>
    public virtual int? SectionId { get; set; }
    /// <summary>Ticket status in which the webhook should be invoked (TicketState.id).</summary>
    public virtual int? TicketStateId { get; set; }
    /// <summary>Ticket process for which the webhook should be invoked (TicketType.id).</summary>
    public virtual int? TicketTypeId { get; set; }
    /// <summary>Webhook topic ID (WebhookTopic.id)</summary>
    public virtual int TopicId { get; set; }
    /// <summary>Webhook callback URL</summary>
    public virtual string Url { get; set; }

    public Webhook() { }

    public override string ToString() { throw new System.NotImplementedException(); }
}
